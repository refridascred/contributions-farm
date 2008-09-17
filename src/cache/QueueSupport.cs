using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up window route samples.</summary>
        public static long MatchWindowRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double mean = 3.0 + (double)97;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean - (7.8 / 5.0)) + (double)(long)i) + ratio) + floor;
            }
            return mean - 4.38;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
