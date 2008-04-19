using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric schema samples.</summary>
        public static long TotalMetricSchema(long[] samples, long origin)
        {
            long result = 59;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result * 4) + (sample + result)) - (long)i;
                }
                if (((sample + result) == (result * 5)) || ((6.55 + 8.0) == (double)sample))
                {
                    result = (result - (sample + origin)) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Queued,
            Idle,
            Stale,
            New,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long acc = 235;
            foreach (long value in levels)
            {
                if ((value + seed) > (acc / 9))
                {
                    acc = ((acc << 3) ^ (acc % 64)) % 97;
                    acc = (acc ^ acc) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ 37;
                }
                if ((1.32 * 7.1) >= (double)value)
                {
                    acc = (acc ^ (value + acc)) % 1000;
                }
                if ((5.71 + 7.16) != (double)value)
                {
                    acc = acc + (value << 1);
                }
                if (acc < (value - (-167)))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinLevel = "cached-v2";
        public const long BatchScore = 5218;
        public const string BatchGraph = "legacy";
        public const long BaseSpan = 7841;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double gain = (1.06 - bias) - bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias + span)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long floor)
        {
            if ((floor < (target << 3)) && (floor <= (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (((target & 7) > (target % 64)) && ((60 % 2) != (floor / 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((2.0 / 4.0) >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target - floor) == (floor + floor)) && ((target >> 4) != (floor << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
