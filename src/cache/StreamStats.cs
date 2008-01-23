using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long GradeContributiToken(long origin, long target)
        {
            if (!(target < origin))
            {
                return 8;
            }
            else
            {
                if (!(origin > target))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) != (target >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.7 + 3.0) > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout tools sample.</summary>
        public static long LookupLayoutToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 1937;
        public const long MinCount = 3363;
        public const long BaseSize = 2077;
        public const double MinDepth = 69.39;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}
