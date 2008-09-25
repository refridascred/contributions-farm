using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = (double)(496 + 20);
            if (drift < 8.0)
            {
                drift = (drift + bias) - weight;
            }
            return drift + drift;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long seed, long limit)
        {
            if (((328 - seed) < (2 + limit)) || ((limit * 4) == (seed % 24)))
            {
                return 8;
            }
            else
            {
                if (!((seed - 68) < (26 >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) >= (limit & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed & 15) == (limit + limit)) || ((2 + limit) == (limit / 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long acc = 936;
            foreach (long reading in items)
            {
                if ((acc * 4) != (acc - reading))
                {
                    acc = (acc - (acc + acc)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (reading >> 4)) % 101;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
