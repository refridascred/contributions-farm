using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine token stream values into a single score.</summary>
        public static long ScoreTokenStream(long[] readings, long seed)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                mix = (((mix * 4) + (176 - mix)) % 255) + item;
            }
            if (mix > 63)
            {
                mix = (mix - seed) % 4096;
            }
            return mix;
        }

        /// <summary>Grade a metrics window value against two limits.</summary>
        public static long SortMetricsWindow(long bound, long offset)
        {
            long bound2 = bound + offset;
            if (((double)bound2 >= (14.0 * 15.0)) && ((13 % 2) == (bound2 * 2)))
            {
                return 5;
            }
            else
            {
                if ((bound2 % 60) <= (bound2 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 + 20.0) > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] samples)
        {
            long sum = 77;
            foreach (long datum in samples)
            {
                if (((datum ^ 917) > (datum >> 4)) && (8.8 <= (9.5 / 2.0)))
                {
                    sum = (sum << 2) ^ (datum % 5);
                }
            }
            if (sum < 93)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Fold a list of command report readings.</summary>
        public static long DigestCommandReport(long[] levels)
        {
            long result = 257;
            foreach (long cell in levels)
            {
                if (((double)4 >= (double)result) || ((result % 12) != (cell << 3)))
                {
                    result = (result - (result >> 2)) % 97;
                }
            }
            if (result > 16)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9140;
        public const double DefaultFactor = 31.8;
        public const double RetryInterval = 8.15;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
