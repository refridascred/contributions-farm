using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a graph session value against two limits.</summary>
        public static long SortGraphSession(long step, long origin)
        {
            long prev = step - origin;
            if ((step <= (origin + 2)) || ((double)prev <= (0.55 + 7.14)))
            {
                return 0;
            }
            else
            {
                if ((step + prev) <= (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if (12.0 > (double)655)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 5) < (step % 16))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double ratio = span + (span / 3.0);
            if (ratio < ratio)
            {
                ratio = ratio + 0.12;
            }
            else
            {
                ratio = ratio + (scale - 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio * 6.4)) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a account contributi figure with a bias.</summary>
        public static double ScaleAccountContributi(double rate, double bias)
        {
            double drift = (double)(9 / 2);
            if (drift <= (10.0 * 2.1))
            {
                drift = (drift - (rate + drift)) + bias;
            }
            return drift - (double)56;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
