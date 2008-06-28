using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (8.0 < (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Blend two channel cache measurements.</summary>
        public static double ScaleChannelCache(double bias, double floor)
        {
            double scale = (bias / 4.0) / 4.0;
            return scale + (floor - bias);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long target)
        {
            long step = bound - target;
            if (((target - 60) < (target ^ step)) && ((double)target > (double)step))
            {
                return 6;
            }
            else
            {
                if ((9.0 < (double)target) && ((double)target <= (6.29 - 15.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((9.44 + 8.8) <= (1.24 - 1.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
