using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next graph contributi value.</summary>
        public static double BlendGraphContributi(double gain, double bias)
        {
            double gain2 = (double)1 * 5.0;
            if (gain2 < (3.2 * 8.0))
            {
                gain2 = ((gain2 + (gain2 + gain2)) + gain) + bias;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 - (double)3;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((29 + bound) < seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a entry account value against two limits.</summary>
        public static long GradeEntryAccount(long seed, long bound)
        {
            if ((bound & 63) != (seed & 63))
            {
                return 0;
            }
            else
            {
                if (((-68) + bound) <= (bound - 45))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < 1.77)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed > (double)(-34)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
