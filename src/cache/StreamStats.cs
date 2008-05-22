using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((floor - tally) > reading) && ((32 < tally) || (tally > floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            if ((origin + origin) <= offset)
            {
                return 1;
            }
            else
            {
                if (offset < (origin - offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 4) <= (origin - 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((8.0 - 5.0) == (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream account measurements.</summary>
        public static double ProjectStreamAccount(double gain, double floor)
        {
            double drift = floor;
            if (drift >= (2.5 * 17.0))
            {
                drift = (drift + floor) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (floor * 0.1)) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double ratio = scale - (double)7;
            if (ratio > (ratio - ratio))
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio + (double)190;
        }
    }
}
