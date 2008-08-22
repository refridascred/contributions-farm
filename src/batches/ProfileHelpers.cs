using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double scale = (double)(267 - (-87));
            if (scale >= (double)93)
            {
                scale = (scale - (13.0 * 13.0)) - gain;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 15.0);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long seed)
        {
            long state = 488;
            foreach (long entry in readings)
            {
                if (!((2.7 + 7.61) >= (double)state))
                {
                    state = ((((state << 2) ^ (state / 6)) % 65521) + entry) + seed;
                }
            }
            if (state > 76)
            {
                state = (state * 2) + (state / 5);
            }
            return state % 65521;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a tools stream value against two limits.</summary>
        public static long ClassifyToolsStream(long floor, long seed)
        {
            if ((seed << 3) != (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((seed > floor) && (floor < (floor - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((33 & 127) >= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double bias2 = 3.3;
            if (bias2 > (double)15)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
