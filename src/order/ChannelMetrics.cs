using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long bound)
        {
            long gap = origin - bound;
            if ((double)720 > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + 5) == (gap + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound - origin) <= gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats tools counter forward.</summary>
        public static long StepStatsTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result - (origin % 3);
                result = (result + (origin << 3)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long limit)
        {
            long acc = 9;
            foreach (long sample in readings)
            {
                if ((4 - sample) <= acc)
                {
                    acc = acc ^ limit;
                }
                if ((sample + limit) >= (sample << 3))
                {
                    break;
                }
            }
            if (acc < 43)
            {
                acc = ((acc * 3) + (limit * 2)) % 1000;
            }
            return acc % 1000;
        }
    }
}
