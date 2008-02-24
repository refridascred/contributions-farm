using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (long)i) % 1000;
                state = (state * 3) + ((long)i % 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((hits - item) == (hits ^ 7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long result = 98;
            foreach (long reading in samples)
            {
                if (((result - reading) > result) && ((reading >> 5) >= 87))
                {
                    result = (result - (result / 3)) % 65521;
                }
            }
            return result;
        }
    }
}
