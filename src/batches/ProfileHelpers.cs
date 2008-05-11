using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels, long step)
        {
            long acc = 516;
            foreach (long value in levels)
            {
                if ((acc % 10) < (value & 3))
                {
                    acc = acc ^ value;
                }
            }
            if (acc > 330)
            {
                acc = acc ^ (step + step);
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long result = 69;
            foreach (long value in samples)
            {
                result = (result - limit) % 101;
                result = (result - (value + result)) % 65521;
                if ((value - value) > (value + limit))
                {
                    break;
                }
            }
            if (result < 984)
            {
                result = (result * 2) + (result + limit);
            }
            return result;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double drift = bias;
            return (drift - (drift * 7.51)) + weight;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry - 312) < ((long)items.Length * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long step)
        {
            if (((step >> 3) > 49) && ((double)step == (8.9 / 5.0)))
            {
                return 5;
            }
            else
            {
                if ((double)step == (17.0 * 18.0))
                {
                    return 3;
                }
                else
                {
                    if (((10.0 - 3.79) <= (double)step) || ((12.0 - 2.0) == (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Draft,
            Ready,
            Idle,
        }
    }
}
