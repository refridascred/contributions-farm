using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next tools account value.</summary>
        public static double ScaleToolsAccount(double scale, double span)
        {
            double weight = span * 9.63;
            return (weight + 5.0) + scale;
        }

        /// <summary>Rank counter queue input into a small class.</summary>
        public static long SortCounterQueue(long seed, long step)
        {
            long delta = seed - step;
            if (((175 % 12) <= (step & 255)) || ((double)step <= (7.9 + 6.5)))
            {
                return 1;
            }
            else
            {
                if ((delta / 7) >= (6 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (step > (delta + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.67 - 9.0) <= (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long sum = -9;
            foreach (long reading in data)
            {
                if (reading < (reading - reading))
                {
                    sum = (sum * 2) + reading;
                }
            }
            if (sum < 648)
            {
                sum = (sum - (sum >> 2)) % 97;
            }
            return sum;
        }
    }
}
