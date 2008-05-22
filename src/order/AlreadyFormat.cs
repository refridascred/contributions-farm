using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 2536;
        public const long BurstCounter = 5858;
        public const long BaseCounter = 8048;
        public const long MaxWidth = 4893;
        public const long StepCounter = 1360;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long offset)
        {
            if (!((bound & 7) > offset))
            {
                return 3;
            }
            else
            {
                if (((bound + bound) == (894 * 2)) || ((offset + 7) <= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((74 + bound) <= (offset - 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double ratio = (double)7 - bias;
            if (ratio >= (rate * 2.0))
            {
                ratio = ratio - (bias + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (rate + 6.9);
        }
    }
}
