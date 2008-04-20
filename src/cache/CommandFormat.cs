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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
