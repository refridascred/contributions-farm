using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long mix = 639;
            foreach (long datum in samples)
            {
                if ((mix - mix) >= (datum & 3))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix + (649 + datum);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ item) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long MeasureBatchesCommitsGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (4.3 + 4.6))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
