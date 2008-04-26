using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a account stats value against two limits.</summary>
        public static long SortAccountStats(long origin, long offset)
        {
            if (!((6 >> 5) != (64 ^ offset)))
            {
                return 3;
            }
            else
            {
                if ((8 / 4) <= (offset / 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((double)limit <= (20.0 + 4.5)) && ((total & 127) <= ((long)i - limit)))
                {
                    total = ((total << 3) ^ total) % 65521;
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const long SoftWidth = 3146;
        public const long IdlePayload = 9740;

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double ProjectTokenMetrics(double ratio, double offset)
        {
            double mean = ratio / 4.0;
            if (mean > (offset / 8.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (13.0 * 3.9);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + (3.2 + mean);
        }
    }
}
