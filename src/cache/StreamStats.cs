using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((step % 64) > step)
            {
                return 1;
            }
            else
            {
                if ((origin - step) >= 31)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 2) == (step % 24))
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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series, long seed)
        {
            long total = 48;
            foreach (long sample in series)
            {
                total = (total ^ (8 + 85)) - seed;
                if ((sample - sample) > total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
