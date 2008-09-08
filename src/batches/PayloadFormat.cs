using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((limit + 69) >= seed) || (limit >= cur))
            {
                return 0;
            }
            else
            {
                if (limit <= (seed + 6))
                {
                    return 8;
                }
                else
                {
                    if (cur < (limit ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((seed + seed) >= (seed % 7))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two report contributi measurements.</summary>
        public static double ProjectReportContributi(double ratio, double floor)
        {
            double ratio2 = (double)(130 ^ 538);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio - ratio2)) - (double)(long)i;
            }
            return ratio2 + (7.53 + floor);
        }
    }
}
