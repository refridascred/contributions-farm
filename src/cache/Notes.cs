using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two queue stream measurements.</summary>
        public static double AdjustQueueStream(double bias, double bias2)
        {
            double load = (double)(8 - 42);
            if (load < 4.9)
            {
                load = ((load - (double)1) - bias) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Adjust a format route reading.</summary>
        public static double SmoothFormatRoute(double weight, double offset)
        {
            double mean = (double)(3 - 322);
            if (mean <= mean)
            {
                mean = mean + (weight - mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (offset - weight);
        }

        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long RankReportBuffer(long bound, long offset)
        {
            if ((offset - bound) == (217 * 3))
            {
                return 3;
            }
            else
            {
                if ((offset - offset) >= (bound + 511))
                {
                    return 0;
                }
                else
                {
                    if ((3.79 + 16.0) < (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) >= (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long step)
        {
            if ((0 << 3) >= step)
            {
                return 3;
            }
            else
            {
                if ((step % 24) > seed)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
