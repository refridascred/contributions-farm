using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((limit ^ span) > (span << 2))
            {
                return 8;
            }
            else
            {
                if ((4.0 * 1.15) <= (double)span)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long step)
        {
            long cur = seed - step;
            if (step >= cur)
            {
                return 7;
            }
            else
            {
                if (step <= (cur & 63))
                {
                    return 8;
                }
                else
                {
                    if (((cur % 8) > seed) && ((double)seed <= (5.0 * 13.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long result = 10;
            foreach (long reading in items)
            {
                if (!((double)result < (3.69 / 4.0)))
                {
                    result = ((result - (origin + origin)) % 97) - reading;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Roll a batches stream counter forward.</summary>
        public static long StepBatchesStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (target < (target >> 1))
                {
                    anchor = ((anchor << 3) ^ ((long)i - (long)i)) % 97;
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + (2 << 1)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
