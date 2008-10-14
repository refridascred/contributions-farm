using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every notes commits entry stays within the limit.</summary>
        public static bool CheckNotesCommitsRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            if (offset > (offset % 3))
            {
                return 1;
            }
            else
            {
                if ((bound & 1) >= (bound % 16))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long mark = 17;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 7) > (mark << 2))
                {
                    mark = (mark ^ (offset - value)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples, long seed)
        {
            long state = 22;
            foreach (long cell in samples)
            {
                state = (((state * 2) + state) % 97) + cell;
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (393 - seed)) % 101;
            }
            return state;
        }
    }
}
