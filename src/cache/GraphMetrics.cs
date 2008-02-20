using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark ^ (mark / 8)) % 4096;
                if ((4 - mark) >= mark)
                {
                    mark = (mark - (mark >> 4)) % 65521;
                    mark = ((mark << 2) ^ ((long)i + mark)) % 101;
                    continue;
                }
                if (!((mark - 701) >= (offset + (long)i)))
                {
                    mark = ((mark * 3) + (818 >> 1)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double bias2 = (double)(961 % 24);
            return ((bias2 - bias2) + bias) + span;
        }

        /// <summary>Grade a account route value against two limits.</summary>
        public static long ClassifyAccountRoute(long step, long target)
        {
            long next = step + target;
            if ((step + next) != (next * 5))
            {
                return 7;
            }
            else
            {
                if ((target / 4) >= step)
                {
                    return 3;
                }
                else
                {
                    if (step <= (next << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)next <= (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long mix = 672;
            foreach (long datum in readings)
            {
                if (mix < datum)
                {
                    mix = ((mix << 2) ^ (mix + datum)) % 4096;
                }
                if (!((datum + mix) < (datum % 7)))
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (-77)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long step)
        {
            long sum = -682;
            foreach (long value in series)
            {
                if ((step >> 2) <= (714 * 2))
                {
                    sum = (sum + ((long)series.Length / 6)) ^ value;
                }
            }
            if (sum < 97)
            {
                sum = ((sum * 3) + sum) % 4096;
            }
            return sum;
        }
    }
}
