using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Iterate the farm account series from a seed.</summary>
        public static long IterateFarmAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ (origin % 3)) % 255) + (long)i2;
                    score = score ^ (score / 2);
                }
                score = ((score * 3) + ((long)i & 1)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long seed)
        {
            long next = bound ^ seed;
            if (next > (700 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)bound > 20.0) || (next >= (seed + next)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 16) <= (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer contributi samples are out of range.</summary>
        public static long TallyBufferContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((target ^ target) == (target & 3)) || ((8.0 / 4.0) == (double)count))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
