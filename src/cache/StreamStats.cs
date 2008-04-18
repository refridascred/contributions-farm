using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long IterateQueueCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (offset ^ 35)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a buffer record reading.</summary>
        public static double BlendBufferRecord(double ratio, double offset)
        {
            double drift = (double)(5 * 2);
            if (drift > (offset / 7.0))
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift + 9.69;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 6.32) - (double)(long)i;
            }
            return drift + (0.7 - 0.25);
        }

        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool ValidateAccountBufferLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Locked,
            Retry,
            Done,
        }
    }
}
