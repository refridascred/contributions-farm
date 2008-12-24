using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                acc = ((acc + (acc + 614)) % 4096) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long MeasureCounterGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((5.35 - 3.9) == (double)(long)data.Length) && ((hits + hits) > hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
