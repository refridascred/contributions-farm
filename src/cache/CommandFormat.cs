using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long sum = -17;
            foreach (long entry in data)
            {
                if (!(((-6) << 3) < (entry / 9)))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long FindClusterContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long step)
        {
            if (origin > (origin ^ origin))
            {
                return 6;
            }
            else
            {
                if ((step & 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)step != (4.2 - 10.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) >= 694)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string HardFactor = "staging";
        public const string CacheSession = "alpha-1";
        public const long WindowDepth = 8094;
        public const string BurstInterval = "local";
    }
}
