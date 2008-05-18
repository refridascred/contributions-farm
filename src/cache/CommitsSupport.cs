using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long origin)
        {
            if (target >= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((target << 1) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((92 - target) <= (target >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy";
        public const long MinFormat = 3321;
        public const string HardSpan = "open";
        public const long IdleFormat = 6759;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
