using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool ValidateBatchesCommitsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long limit)
        {
            long slot = step ^ limit;
            if (((slot & 63) >= (slot / 4)) || ((17.0 + 9.4) >= (double)slot))
            {
                return 0;
            }
            else
            {
                if (((double)step > 18.0) || ((limit - step) >= limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 1) > (step << 1))
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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
