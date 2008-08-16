using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long step)
        {
            long anchor = 728;
            foreach (long sample in series)
            {
                anchor = ((anchor ^ (step + step)) % 65521) - sample;
            }
            return anchor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long floor)
        {
            if (9 <= (55 + seed))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) >= 670)
                {
                    return 3;
                }
                else
                {
                    if ((seed >= (floor + seed)) || ((double)seed <= (1.53 - 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 97) <= (seed << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
