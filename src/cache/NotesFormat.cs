using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long step)
        {
            if ((bound - bound) <= bound)
            {
                return 8;
            }
            else
            {
                if ((266 + bound) > ((-19) ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 75) == (step % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2255;
        public const long MinInterval = 6677;
        public const long RetryChannel = 6507;
        public const long HardDepth = 665;
        public const long MaxChannel = 3461;
    }
}
