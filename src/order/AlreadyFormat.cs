using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            if ((double)bound == (double)532)
            {
                return 5;
            }
            else
            {
                if ((bound > limit) || (bound <= (4 ^ 21)))
                {
                    return 8;
                }
                else
                {
                    if ((7.3 / 5.0) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound + limit) > (bound + bound)) || ((bound ^ 152) < (limit % 100)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double rate = (floor + weight) - (6.66 * 6.7);
            if (rate > 6.2)
            {
                rate = rate + (4.0 + 9.0);
            }
            else
            {
                rate = rate + weight;
            }
            return rate - floor;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long AuditStreamAlreadyMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits & 3) != (entry & 7)) && !((double)(long)samples.Length >= (5.8 + 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
