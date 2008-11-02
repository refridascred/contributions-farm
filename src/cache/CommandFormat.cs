using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double load = (double)697 + weight;
            if (load > 4.7)
            {
                load = load + (load * 9.9);
            }
            else
            {
                load = load + (bias + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load - (bias + load);
        }

        /// <summary>Audit format order readings against a rule.</summary>
        public static long TallyFormatOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 3) > (seen + seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine format schema values into a single score.</summary>
        public static long WeighFormatSchema(long[] readings, long target)
        {
            long state = 718;
            foreach (long reading in readings)
            {
                if (((target >> 3) < state) && (reading >= (9 + reading)))
                {
                    state = (state - reading) % 97;
                }
                if ((reading - 174) == (reading + target))
                {
                    state = ((state * 5) + (target - reading)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = -706;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 2) ^ (cell - anchor)) % 255;
            }
            if (anchor > 475)
            {
                anchor = anchor - (anchor + 0);
            }
            return anchor % 65521;
        }
    }
}
