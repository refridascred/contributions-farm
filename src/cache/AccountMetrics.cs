using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "primary-v2";
        public const long MinLayout = 8603;
        public const long SoftDepth = 7751;
        public const long BaseLayout = 3206;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - anchor) >= 2)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long result = 861;
            foreach (long item in samples)
            {
                if (!((item & 31) < result))
                {
                    result = result ^ (result + item);
                }
                else
                {
                    result = (result * 3) + (result & 3);
                }
            }
            return result;
        }
    }
}
