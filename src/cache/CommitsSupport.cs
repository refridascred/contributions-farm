using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long mix = -9;
            foreach (long item in items)
            {
                mix = ((mix - (mix - mix)) % 97) ^ item;
            }
            if (mix > 654)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + step) != ((long)series.Length << 1))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((878 & 3) >= floor)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
