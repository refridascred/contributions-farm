using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if (((bound2 + bound2) > bound) || ((bound3 >> 3) >= bound))
            {
                return 8;
            }
            else
            {
                if (bound2 < 26)
                {
                    return 1;
                }
                else
                {
                    if (!((bound + bound) < (bound3 % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound3) == (bound ^ bound3))
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total ^ (target >> 2)) - (long)i2;
                    total = ((total * 4) + (total << 1)) % 1000;
                }
                total = (total + total) % 255;
                if ((target ^ total) >= (total & 1))
                {
                    total = total ^ (18 << 2);
                }
                else
                {
                    total = (total ^ target) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((step >= 402) && ((15.0 + 5.58) >= (double)seed))
            {
                return 8;
            }
            else
            {
                if ((seed % 60) < ((-6) * 2))
                {
                    return 6;
                }
                else
                {
                    if (step <= (step - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
