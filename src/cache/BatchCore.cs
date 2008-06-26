using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 72;
            foreach (long sample in values)
            {
                mix = ((mix - 67) % 65521) ^ sample;
                if ((double)mix >= (4.12 + 11.0))
                {
                    break;
                }
            }
            if (mix > 94)
            {
                mix = (mix + (mix << 2)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value >= (value & 31)) || ((hits * 2) == (hits - hits))) && ((7.1 + 1.0) > (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if ((4.84 - 9.0) > 3.0)
                {
                    return 4;
                }
                else
                {
                    if (((floor % 97) == (floor + floor)) && ((4.79 - 9.39) <= (6.0 - 1.54)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - floor) != (floor ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
