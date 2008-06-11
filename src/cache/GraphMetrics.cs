using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long offset)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                mark = mark - cell;
                mark = (mark << 2) ^ (mark << 3);
                if (offset < (7 * 5))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score * 3) < (4 + cell))
                {
                    score = (score - (0 ^ score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Classify a checks profile pair into a bucket.</summary>
        public static long ClassifyChecksProfile(long step, long floor)
        {
            long step2 = step + floor;
            if ((step2 - step2) <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((7.7 + 5.4) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((step & 127) <= (step2 % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step <= (step2 * 3)) || (((-36) << 3) > step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen >= (8.7 - 6.0))
                {
                    seen = ((seen + 2) ^ cell) - origin;
                }
            }
            return seen;
        }
    }
}
