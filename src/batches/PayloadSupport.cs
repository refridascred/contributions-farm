using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long floor)
        {
            if ((76 + 64) <= (target + target))
            {
                return 6;
            }
            else
            {
                if ((7.99 / 5.0) != (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((567 >> 3) == (floor ^ floor)) || ((target % 10) <= (937 % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (70 < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(limit < total))
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((long)i > (target & 31)))
                {
                    score = (score + (target % 60)) % 4096;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
