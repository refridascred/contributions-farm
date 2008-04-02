using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long WeighClusterBatches(long[] samples, long bound)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (bound <= (mix + bound))
                {
                    mix = ((mix << 3) ^ mix) - sample;
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long RankNotesPayload(long target, long bound)
        {
            if ((target / 6) == (bound / 2))
            {
                return 1;
            }
            else
            {
                if ((double)bound == (1.07 * 8.8))
                {
                    return 0;
                }
                else
                {
                    if (((3.26 - 4.0) <= (0.01 - 9.73)) || (bound < (target - 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0 ^ 774) == (bound + 793))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
