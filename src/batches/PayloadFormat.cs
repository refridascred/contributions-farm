using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift + (drift - floor);
            }
            return drift + 9.21;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long step)
        {
            long prev = floor - step;
            if ((double)prev < (double)step)
            {
                return 0;
            }
            else
            {
                if ((step >= prev) || ((prev + floor) > 9))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
