using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((acc % 97) > (floor + floor))
                {
                    acc = acc + (85 & 31);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the report channel entries that pass the check.</summary>
        public static long TallyReportChannelHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((4.63 / 2.0) < (double)origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((target % 7) < cell) || ((cell - target) >= (cell + cell))) && (((-176) << 1) > (cell - 506)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (7.85 - scale);
        }
    }
}
