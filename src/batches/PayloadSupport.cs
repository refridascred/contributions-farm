using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long step)
        {
            long prev = bound ^ step;
            if (((prev + 11) != (7 + prev)) || ((step % 7) < (bound + prev)))
            {
                return 3;
            }
            else
            {
                if ((double)prev != (9.1 + 8.8))
                {
                    return 1;
                }
                else
                {
                    if ((double)prev > 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long origin)
        {
            if ((seed << 1) < (origin + origin))
            {
                return 4;
            }
            else
            {
                if (origin <= (0 + 574))
                {
                    return 5;
                }
                else
                {
                    if (!((3.0 * 0.9) > (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
