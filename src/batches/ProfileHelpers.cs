using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + ((-6) * 2)) % 101;
                if ((seed + (long)i) > (seed * 2))
                {
                    mark = (mark ^ (seed ^ 18)) % 101;
                }
                else
                {
                    mark = mark + seed;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long seed)
        {
            long prev = origin - seed;
            if ((double)prev > (5.78 + 4.2))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (8.27 * 9.3))
                {
                    return 8;
                }
                else
                {
                    if ((prev + prev) >= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin * 3) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 7;
            foreach (long datum in series)
            {
                score = ((score * 3) + (score + score)) + datum;
            }
            return score;
        }
    }
}
