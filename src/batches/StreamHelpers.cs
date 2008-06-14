using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                if (cell <= acc)
                {
                    acc = (acc ^ (cell & 7)) % 255;
                }
            }
            if (acc < 89)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally <= (10.0 - 5.35))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double rate = bias;
            if (rate > (double)260)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)31;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate * 2.32)) + (double)(long)i;
            }
            return rate + (rate + 6.94);
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Ready,
            Closed,
        }
    }
}
