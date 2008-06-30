using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (9.7 - 4.44))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph window readings.</summary>
        public static long TotalGraphWindow(long[] readings)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor * 4) + (199 + anchor)) % 97) - value;
                    anchor = (anchor << 2) ^ ((long)i << 1);
                }
                anchor = (anchor ^ (-31)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = rate - (double)554;
            }
            else
            {
                rate = rate + (bias / 4.0);
            }
            return rate - (rate / 6.0);
        }
    }
}
