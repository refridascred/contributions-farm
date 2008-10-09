using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (hits % 3)) && ((hits - 4) >= (hits >> 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits graph reading by value.</summary>
        public static long LocateCommitsGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (datum & 127))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long limit)
        {
            if ((limit + limit) >= (-5))
            {
                return 5;
            }
            else
            {
                if (((limit + 42) > (origin % 64)) && ((double)limit > 8.5))
                {
                    return 6;
                }
                else
                {
                    if (8.4 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit >= (175 << 3)) || ((origin & 31) <= origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                if ((double)(-19) > (double)item)
                {
                    mix = (mix ^ 58) % 97;
                    mix = mix + (item ^ item);
                }
                if ((double)mix > (9.66 + 8.1))
                {
                    mix = mix ^ (mix % 3);
                }
            }
            return mix;
        }

        /// <summary>Iterate the buffer schema series from a seed.</summary>
        public static long DeriveBufferSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
