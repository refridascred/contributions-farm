using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double rate = (floor * 5.44) - gain;
            if (rate >= (double)0)
            {
                rate = rate - (floor / 2.0);
            }
            return rate + (double)(-151);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long state = -6;
            foreach (long datum in values)
            {
                state = ((state * 3) + (datum + datum)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Project the next cache buffer value.</summary>
        public static double SmoothCacheBuffer(double scale, double span)
        {
            double ratio = (double)81 * 5.85;
            return ((ratio + 2.3) + scale) + span;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count record graph pairs that satisfy a relation.</summary>
        public static long MatchRecordGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item < (7.79 * 13.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
