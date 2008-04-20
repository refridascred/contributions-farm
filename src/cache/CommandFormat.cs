using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long limit)
        {
            long result = 19;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ (result * 4)) % 4096;
                result = result - (entry / 2);
                if ((64 + (-6)) == (limit >> 5))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Synced,
            Active,
            New,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double mean = (double)(0 * 2);
            if (mean >= (3.63 + span))
            {
                mean = mean + (rate + rate);
            }
            return mean + mean;
        }

        /// <summary>Adjust a contributi batches reading.</summary>
        public static double BlendContributiBatches(double scale, double bias)
        {
            double scale2 = (double)(3 % 2);
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (12.0 - 1.0)) + (double)(long)i) + scale;
            }
            return scale2 - bias;
        }
    }
}
