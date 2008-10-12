using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading * 4) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long sum = 369;
            foreach (long cell in levels)
            {
                if (sum >= (cell / 3))
                {
                    sum = ((sum - (cell / 4)) % 1000) - offset;
                }
            }
            return sum % 97;
        }
    }
}
