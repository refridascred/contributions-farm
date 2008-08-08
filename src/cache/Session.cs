using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Ready,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long TallyQueueMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits & 255) > (hits ^ hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}
