using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long entry in levels)
            {
                anchor = (anchor - (origin / 7)) % 255;
                if ((((-620) / 9) <= (entry << 3)) || ((18.0 - 3.1) < (double)origin))
                {
                    anchor = (anchor + (anchor & 63)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if (((gap % 2) < (offset + (-435))) || ((gap << 2) > (gap >> 2)))
            {
                return 4;
            }
            else
            {
                if ((88 > (offset / 3)) && ((double)gap > (2.2 + 18.0)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                if ((acc - (-98)) > sample)
                {
                    acc = (acc ^ sample) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a contributi record figure with a bias.</summary>
        public static double BlendContributiRecord(double gain, double floor)
        {
            double load = gain;
            if (load > gain)
            {
                load = load - (gain - floor);
            }
            return load - load;
        }
    }
}
