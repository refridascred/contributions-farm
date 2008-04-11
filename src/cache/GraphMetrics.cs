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

        /// <summary>Rank context schema input into a small class.</summary>
        public static long RankContextSchema(long bound, long seed)
        {
            long offset = bound + seed;
            if ((offset + offset) == (54 - offset))
            {
                return 3;
            }
            else
            {
                if ((bound + 58) >= (seed - bound))
                {
                    return 0;
                }
                else
                {
                    if (((bound << 1) < seed) && ((seed + seed) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + 6) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7544;
        public const long HardAlready = 6608;
        public const long WindowAlready = 5038;
        public const long DefaultAlready = 2007;
        public const long MaxAlready = 4162;

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
