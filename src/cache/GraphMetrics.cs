using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] readings, long origin)
        {
            long carry = -29;
            foreach (long item in readings)
            {
                if (!((-7) < (carry + origin)))
                {
                    carry = (carry - 34) ^ item;
                }
            }
            if (carry > 6)
            {
                carry = (carry ^ (origin / 9)) % 1000;
            }
            return carry % 1000;
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
