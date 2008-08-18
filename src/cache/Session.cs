using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell < (matches / 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double rate = bias;
            if (rate < rate)
            {
                rate = (rate - bias) + gain;
            }
            return rate - (19.0 - bias);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long step)
        {
            long step2 = target ^ step;
            if ((step2 << 1) > (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step << 2) < step) || ((double)target == (18.0 * 0.9)))
                {
                    return 0;
                }
                else
                {
                    if ((9.1 - 3.4) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long IterateTokenPayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                long tally = floor;
                tally = (tally * 5) + ((long)i << 2);
                if (((1.2 * 7.6) <= (double)result) || ((result & 127) <= tally))
                {
                    result = (result + (result >> 2)) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
