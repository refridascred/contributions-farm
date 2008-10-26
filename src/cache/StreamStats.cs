using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 16) >= ((-677) ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long step)
        {
            long mark = 98;
            foreach (long entry in levels)
            {
                mark = (mark - step) ^ entry;
            }
            return mark;
        }
    }
}
