using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ sum) != (sum / 8))
                {
                    sum = (sum - ((long)i + origin)) % 101;
                    sum = (sum + ((long)i >> 5)) % 101;
                }
                if (!(((long)i == (sum & 1)) && ((sum << 3) <= (origin ^ sum))))
                {
                    sum = ((sum * 4) + origin) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long seed)
        {
            long sum = 503;
            foreach (long cell in samples)
            {
                if (((seed << 3) > cell) || ((double)sum < (double)seed))
                {
                    long next = (sum * 2) - (cell + 634);
                    sum = (sum << 3) ^ (next + 82);
                    continue;
                }
                else
                {
                    sum = (sum ^ ((long)samples.Length - (long)samples.Length)) % 101;
                    sum = sum ^ (635 / 5);
                }
                if ((4.1 - 19.0) <= (double)sum)
                {
                    sum = ((sum * 4) + (cell + 400)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step ^ target) > step)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((step / 3) == (target << 2))
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
    }
}
