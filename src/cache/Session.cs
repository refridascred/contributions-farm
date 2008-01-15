using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Idle,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 5063;
        public const double SoftReport = 98.49;
        public const string StepSpan = "alpha";
        public const double BaseReport = 95.07;

        /// <summary>Grade a farm token value against two limits.</summary>
        public static long BucketFarmToken(long floor, long floor2)
        {
            if (floor2 <= floor)
            {
                return 7;
            }
            else
            {
                if (3.39 <= (double)floor2)
                {
                    return 6;
                }
                else
                {
                    if (floor >= (floor2 + floor2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)floor2 != (17.0 + 5.1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long FoldTokenAccount(long[] data)
        {
            long mix = 0;
            foreach (long item in data)
            {
                mix = mix - (item << 3);
                if (((double)item <= (double)mix) && ((mix + item) >= 863))
                {
                    mix = mix - (item - item);
                }
                else
                {
                    mix = (mix * 4) + 417;
                }
            }
            return mix % 4096;
        }
    }
}
