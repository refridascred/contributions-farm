using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long target)
        {
            long acc = -254;
            foreach (long entry in levels)
            {
                acc = (acc - (target + acc)) - entry;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long mark = 94;
            foreach (long sample in levels)
            {
                long slot = (242 + sample) ^ (sample - sample);
                if (((double)mark < (15.0 - 8.9)) || ((slot + sample) == (sample >> 5)))
                {
                    slot = slot ^ (sample % 2);
                    slot = (slot + sample) % 97;
                    break;
                }
                else
                {
                    slot = (slot << 2) ^ (sample << 2);
                }
                if (((86 - 32) > mark) && ((mark ^ mark) != (mark ^ 129)))
                {
                    mark = ((mark * 2) + sample) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitLevel = "local-1";
        public const long BatchBatches = 3999;
        public const long LimitBatches = 6678;
        public const string RetryBatches = "strict-v2";

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            if ((836 - offset) < offset)
            {
                return 2;
            }
            else
            {
                if ((offset / 5) < offset)
                {
                    return 3;
                }
                else
                {
                    if (7 > (seed + 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) != (seed >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
