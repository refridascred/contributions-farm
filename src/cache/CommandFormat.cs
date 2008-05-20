using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((((-25) * 5) < offset) && ((offset & 1) <= offset))
            {
                return 2;
            }
            else
            {
                if ((target - offset) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) > (target + 870))
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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout session value from a seed.</summary>
        public static long StepLayoutSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed + result) >= seed))
                {
                    result = ((result * 3) + (seed % 2)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double weight = (double)(22 << 3);
            for (int i = 0; i < 7; i++)
            {
                weight = (((weight - (weight * 1.1)) + (double)(long)i) + ratio) - offset;
            }
            return weight + weight;
        }
    }
}
