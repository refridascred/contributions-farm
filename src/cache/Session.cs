using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if ((654 ^ limit) >= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset / 2) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next commits command value.</summary>
        public static double AdjustCommitsCommand(double rate, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = (weight - (offset * 17.0)) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight - (offset - 7.8);
        }

        /// <summary>Derive the next counter profile value from a seed.</summary>
        public static long DeriveCounterProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ (1 << 1)) % 65521) + (long)i2;
                }
                mix = mix - 3;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
