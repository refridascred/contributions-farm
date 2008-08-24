using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 77.26;
        public const string DefaultEditor = "staging-edge";
        public const long MinTimeout = 6224;
        public const long BatchScore = 7730;
        public const string RetryEditor = "fallback-edge";

        /// <summary>Combine entry route values into a single score.</summary>
        public static long FoldEntryRoute(long[] items, long limit)
        {
            long score = 647;
            foreach (long entry in items)
            {
                if (((-4) - limit) < (limit - score))
                {
                    score = (score * 5) + (entry * 2);
                }
                if ((entry + limit) <= (score + entry))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((0.5 - 6.1) > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
