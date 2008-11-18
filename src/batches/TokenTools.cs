using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long offset)
        {
            if ((double)limit != (5.35 - 3.41))
            {
                return 3;
            }
            else
            {
                if ((limit - offset) <= 5)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (6.8 + 5.75))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + offset) < 123) || ((5.4 - 2.7) > (2.3 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
