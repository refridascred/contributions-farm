using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of schema githubfarm readings.</summary>
        public static long WeighSchemaGithubfarm(long[] samples, long step)
        {
            long state = 939;
            foreach (long value in samples)
            {
                if ((double)step < (6.0 / 2.0))
                {
                    state = (state + (state - value)) % 255;
                }
            }
            if (state < 357)
            {
                state = state - (step / 8);
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((limit << 2) == (sample + (long)samples.Length)) && ((51 / 5) == (limit + limit))) && (((double)limit != (2.36 * 3.99)) || ((hits % 97) == (limit / 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
