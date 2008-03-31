using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long offset)
        {
            long cur = origin - offset;
            if ((cur - offset) > (407 / 5))
            {
                return 8;
            }
            else
            {
                if ((2 - offset) < (cur >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((cur + cur) == (offset * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin >= (offset + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            New,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-v2";
        public const string StepFarm = "stable";
        public const long RetryFarm = 8642;
        public const long LimitWidth = 7763;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double bias2 = rate * 2.2;
            if (bias2 > (double)(-12))
            {
                bias2 = bias2 + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
