using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                mix = ((mix + reading) % 4096) + offset;
            }
            return mix;
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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
