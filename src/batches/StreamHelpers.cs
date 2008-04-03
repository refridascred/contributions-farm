using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if (target >= (long)i)
                {
                    mix = mix - (34 + mix);
                }
                else
                {
                    mix = mix ^ target;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((89 + reading) <= (reading + 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account batches samples.</summary>
        public static long WeighAccountBatches(long[] samples, long target)
        {
            long acc = 14;
            foreach (long item in samples)
            {
                if ((double)target < (5.9 * 3.0))
                {
                    acc = (acc + (target + item)) % 101;
                }
            }
            if (acc < 58)
            {
                acc = (acc ^ (target + target)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Idle,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= 855)
                {
                    hits = ((hits + 1) - entry) - limit;
                }
            }
            return hits;
        }
    }
}
