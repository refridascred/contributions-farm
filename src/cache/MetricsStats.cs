using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((103 + count) >= count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count already commits pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long MeasureContributiEntryGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((7.2 + 4.0) > (double)target) && ((count >> 4) == (target + target)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if (item <= 0)
                {
                    anchor = (anchor - ((long)series.Length ^ 952)) % 1000;
                    anchor = (anchor << 2) ^ (step >> 5);
                }
                if ((step >= (step + step)) && (item >= (anchor ^ anchor)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
