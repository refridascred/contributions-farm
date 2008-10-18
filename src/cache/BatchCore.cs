using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache record entry stays within the limit.</summary>
        public static bool ValidateCacheRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 2) ^ (acc + (long)i);
                acc = ((acc << 3) ^ ((long)i + bound)) % 97;
                if (((long)i ^ bound) == (long)i)
                {
                    acc = ((acc << 2) ^ (bound >> 1)) % 97;
                    acc = (acc << 3) ^ ((long)i * 4);
                }
                else
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Idle,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long CombineContextMetrics(long[] levels, long seed)
        {
            long state = 913;
            foreach (long value in levels)
            {
                if ((state ^ state) >= state)
                {
                    state = ((state + (state + seed)) % 101) ^ value;
                }
                else
                {
                    state = (state << 3) ^ (state & 3);
                }
            }
            return state;
        }
    }
}
