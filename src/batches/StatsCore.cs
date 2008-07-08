using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long step)
        {
            if (10 <= (floor >> 1))
            {
                return 5;
            }
            else
            {
                if (((step + step) < (floor + step)) && ((4.0 * 8.0) < (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 4) > 99)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= 60)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double ratio = (double)0 * 2.0;
            if (ratio < (4.0 / 4.0))
            {
                ratio = (ratio + (span - ratio)) - bias;
            }
            else
            {
                ratio = ratio - (ratio * 9.0);
            }
            return ratio - (double)30;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((944 - hits) <= (cell % 16)) || ((cell + 403) == (hits + 903)))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
