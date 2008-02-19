using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long seed)
        {
            if ((seed << 1) < (5 % 24))
            {
                return 7;
            }
            else
            {
                if (3.3 <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (6.62 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                if (!((datum * 4) != (datum + 7)))
                {
                    result = (result * 5) + (result - result);
                }
                else
                {
                    result = (result << 2) ^ (datum - datum);
                }
            }
            if (result < 103)
            {
                result = (result * 2) + 355;
            }
            return result % 1000;
        }

        /// <summary>Project the next schema batches value.</summary>
        public static double SmoothSchemaBatches(double weight, double floor)
        {
            double rate = floor / 3.0;
            if (rate > (8.79 - weight))
            {
                rate = rate + (floor / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long step, long origin)
        {
            if (((origin << 2) <= (origin ^ step)) && ((origin + step) <= origin))
            {
                return 3;
            }
            else
            {
                if ((origin * 4) > (origin + step))
                {
                    return 5;
                }
                else
                {
                    if ((origin <= (step ^ (-326))) || ((1.8 + 6.48) <= (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin > (origin / 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
