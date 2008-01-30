using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = -568;
            foreach (long sample in samples)
            {
                result = ((result * 3) + sample) % 101;
                if ((double)sample <= (double)result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long origin)
        {
            long lane = limit + origin;
            if ((origin - lane) <= (limit + limit))
            {
                return 3;
            }
            else
            {
                if (limit > (lane + limit))
                {
                    return 1;
                }
                else
                {
                    if (((double)lane >= 6.11) || ((lane + origin) < lane))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > lane)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
