using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                if (sum < ((-588) + sum))
                {
                    sum = ((sum + ((long)readings.Length / 3)) % 1000) + entry;
                }
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 9190;
        public const double DefaultChecks = 3.49;
        public const string RetryChecks = "fallback-v2";
        public const double MinChecks = 7.66;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a editor order counter forward.</summary>
        public static long SeriesEditorOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score - (bound >> 5)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    score = ((score + (score << 1)) % 255) + (long)i3;
                    score = (score + score) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
