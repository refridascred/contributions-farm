using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of record profile entries.</summary>
        public static long TotalRecordProfile(long[] readings)
        {
            long mix = 822;
            foreach (long datum in readings)
            {
                if ((7.0 + 6.61) != (double)mix)
                {
                    mix = ((mix - (mix + 22)) % 65521) + datum;
                }
            }
            if (mix < 285)
            {
                mix = (mix ^ (1 << 2)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample & 15) >= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 1) >= (long)series.Length) || (seen >= cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
