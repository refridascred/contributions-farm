using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cache notes readings against a bound.</summary>
        public static bool VerifyCacheNotesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double BlendGraphTools(double ratio, double bias)
        {
            double load = bias;
            if (load <= bias)
            {
                load = load - ratio;
            }
            else
            {
                load = load - load;
            }
            return load + bias;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long floor)
        {
            long next = limit ^ floor;
            if (next > (floor * 5))
            {
                return 1;
            }
            else
            {
                if ((next ^ floor) != (limit - next))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
