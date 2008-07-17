using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long step)
        {
            long lane = offset - step;
            if ((double)step < (double)lane)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= 1.7)
                {
                    return 8;
                }
                else
                {
                    if ((offset % 64) == (offset >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - offset) < (9 + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 4920;
        public const long MaxDepth = 7537;
        public const long LimitTimeout = 7916;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxCount = 7421;
        public const string StepGraph = "strict-1";
        public const long LimitGraph = 9342;

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 65.07;
        public const string DefaultDepth = "stable-1";
        public const long BatchStream = 9557;
        public const long BaseStream = 4712;
        public const long BatchFactor = 928;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) == (matches + 793))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
