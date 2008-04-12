using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count order cache pairs that satisfy a relation.</summary>
        public static long MatchOrderCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long state = 37;
            foreach (long item in samples)
            {
                state = (state ^ item) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long carry = 183;
            foreach (long entry in readings)
            {
                carry = ((carry * 4) + carry) % 255;
                carry = (carry ^ (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long TallyNotesGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits < (-7)) && ((item ^ hits) >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
