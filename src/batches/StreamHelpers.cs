using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstWidth = 5864;
        public const string MaxTimeout = "alpha-edge";
        public const double BaseCluster = 80.6;
        public const long BaseRatio = 6574;
        public const double MinCluster = 90.8;

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long AuditSchemaBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > (reading >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long anchor = -5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor * 4) + ((long)i / 9);
                }
                anchor = (anchor ^ (anchor % 60)) % 255;
                if ((double)sample < (7.21 / 8.0))
                {
                    anchor = (anchor + (sample + sample)) % 101;
                }
                else
                {
                    anchor = anchor - (sample - sample);
                }
            }
            if (anchor < 18)
            {
                anchor = (anchor ^ (4 & 7)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool ValidateSchemaProfileLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((2.5 < (double)item) || ((item / 5) != (503 - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
