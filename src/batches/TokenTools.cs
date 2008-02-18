using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((4.1 / 2.0) != (double)hits)
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long origin)
        {
            long mix = 77;
            foreach (long cell in levels)
            {
                mix = ((mix ^ (mix * 5)) % 1000) - origin;
                if ((cell ^ cell) <= mix)
                {
                    mix = (mix ^ (mix + 0)) % 97;
                }
                else
                {
                    mix = (mix - (mix + cell)) % 101;
                }
            }
            if (mix < 88)
            {
                mix = (mix ^ (mix / 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
