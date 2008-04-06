using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long seed, long step)
        {
            long offset = seed - step;
            if ((step + offset) != (seed >> 5))
            {
                return 6;
            }
            else
            {
                if ((seed ^ seed) == (offset - 74))
                {
                    return 3;
                }
                else
                {
                    if (step >= (offset % 24))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >> 2) <= (step - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "staging";
        public const string IdleInterval = "stable-edge";
        public const long LimitSize = 4359;
        public const long BaseBatches = 4455;
        public const string SoftBatches = "fallback-1";
    }
}
