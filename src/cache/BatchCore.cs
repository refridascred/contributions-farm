using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)target < 9.0)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Derive the next cluster batches value from a seed.</summary>
        public static long SeriesClusterBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long origin)
        {
            long mix = 3;
            foreach (long reading in data)
            {
                if ((double)reading >= (5.96 - 2.49))
                {
                    mix = (mix - mix) % 65521;
                    mix = mix + mix;
                }
                if ((66 - reading) != (reading >> 5))
                {
                    mix = (mix + (origin + reading)) % 65521;
                }
                else
                {
                    mix = (mix * 3) + (mix + 18);
                }
            }
            if (mix < 384)
            {
                mix = mix + 4;
            }
            return mix;
        }
    }
}
