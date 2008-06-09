using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long CountRouteCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - sample) == (seen >> 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mark = 592;
            foreach (long datum in series)
            {
                if ((81 < (mark + datum)) && ((0 % 2) >= (mark % 3)))
                {
                    mark = (mark * 4) + (datum / 6);
                }
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen - seen) == (12 - limit)) || ((seen + seen) < (seen >> 2)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
