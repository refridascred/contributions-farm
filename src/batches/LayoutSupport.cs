using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long AuditCommitsSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen + seen) > (reading & 31)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 4522;
        public const double WindowWidth = 1.56;
        public const double BurstLevel = 98.49;
        public const long WindowNotes = 143;

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepDepth = 7263;
        public const double BatchFilter = 89.12;
        public const long MaxLevel = 8921;
        public const long MaxFilter = 1799;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((3 & 63) < cell)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
