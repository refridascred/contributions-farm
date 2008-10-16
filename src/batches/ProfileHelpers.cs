using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 127) > (step % 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ (carry - carry)) ^ cell;
                if ((double)carry >= 4.5)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double weight = (floor / 4.0) - (double)9;
            if (weight > (double)7)
            {
                weight = weight + (floor / 4.0);
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (bias / 8.0)) + (double)(long)i;
            }
            return weight + (9.0 / 9.0);
        }
    }
}
