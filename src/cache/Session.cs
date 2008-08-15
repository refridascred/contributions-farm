using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if (offset >= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!(((-182) & 1) >= (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset < (floor % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((547 + offset) != (offset << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 29.13;
        public const long RetrySize = 6578;
        public const string StepCommand = "fallback-edge";

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
