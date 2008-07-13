using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if (!((floor * 3) >= (origin ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((9.08 + 3.74) == (double)origin) || ((4.9 / 9.0) >= (7.47 + 2.0)))
                {
                    return 5;
                }
                else
                {
                    if ((30 * 5) == (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((origin ^ 7) <= ((-80) ^ 299))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (floor ^ floor)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
