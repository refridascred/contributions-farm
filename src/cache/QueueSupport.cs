using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target << 3) > (target + total))
                {
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long offset = target % 2;
                    total = (total ^ offset) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long floor)
        {
            if (floor >= (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (((double)floor != (5.58 - 17.0)) && ((floor & 31) > limit))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor > (2.4 + 0.35)) && ((limit ^ limit) > (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) < limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
