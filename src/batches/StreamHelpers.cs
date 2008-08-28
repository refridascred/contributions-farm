using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i == (total ^ floor)) || ((floor * 4) > (total - total))))
                {
                    total = (total << 2) ^ (floor ^ (long)i);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((double)8 >= (double)score) || ((double)(long)i != (double)target))
                {
                    score = score ^ (score ^ target);
                    score = (score * 2) + (score - (long)i);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-edge";
        public const string HardOrder = "stable-v2";
        public const double StepOrder = 74.5;

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((20.0 * 9.0) > (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
