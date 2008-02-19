using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long floor)
        {
            if ((floor + floor) <= (-967))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (9.28 - 12.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 9) >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = weight - 17.0;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight - (14.0 - ratio);
        }

        /// <summary>Match up stream order samples.</summary>
        public static long OverlapStreamOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((92 + item) > (item * 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long target)
        {
            long anchor = 43;
            foreach (long cell in readings)
            {
                long tally = cell * 5;
                if ((tally - target) >= (587 + cell))
                {
                    tally = tally - anchor;
                }
                else
                {
                    anchor = anchor - target;
                }
                if ((target > (target - 576)) || ((double)target <= 7.0))
                {
                    anchor = (anchor << 2) ^ (target >> 4);
                }
                else
                {
                    anchor = (anchor - 588) % 101;
                }
            }
            return anchor;
        }
    }
}
