using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double gain = ratio;
            return (gain + (ratio + gain)) + floor;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                long span = (item % 8) ^ 9;
                if (!((2.0 + 1.91) > (double)span))
                {
                    result = ((result * 2) + (result + item)) % 255;
                }
                result = (result ^ (result % 24)) % 1000;
            }
            if (result < 4)
            {
                result = ((result << 3) ^ 0) % 65521;
            }
            return result;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long step)
        {
            if ((double)step == (3.0 + 8.0))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) < (65 - step)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "open";
        public const long BaseLayout = 1196;
        public const double HardSpan = 86.77;
        public const long IdleSize = 3228;
        public const string BurstLayout = "stable-v2";

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
