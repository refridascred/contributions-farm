using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double weight = gain;
            if (weight < 4.5)
            {
                weight = weight - (offset + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (20.0 + gain);
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= 9.88)
            {
                gain2 = (gain2 - (1.71 + floor)) - gain;
            }
            else
            {
                gain2 = gain2 - (double)35;
            }
            return gain2 - 6.8;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long step, long offset)
        {
            if ((double)step <= 2.5)
            {
                return 2;
            }
            else
            {
                if (!((double)offset >= (double)step))
                {
                    return 8;
                }
                else
                {
                    if (!((6.0 - 2.06) < 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + offset) == (step / 5))
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "cached-v2";
        public const long MinEditor = 7090;
        public const long MaxFactor = 5957;
        public const long IdleBudget = 2521;
        public const long StepEditor = 6526;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
