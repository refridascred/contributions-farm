using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (origin ^ origin);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of command schema readings.</summary>
        public static long TotalCommandSchema(long[] readings)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                score = (score - (score - score)) - reading;
            }
            if (score < 136)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item > 3.55)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Audit support entry readings against a rule.</summary>
        public static long MeasureSupportEntryOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((bound ^ tally) != (tally - tally))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
