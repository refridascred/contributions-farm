using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long score = 66;
            foreach (long sample in data)
            {
                if ((double)score <= (15.0 + 12.0))
                {
                    score = score ^ (score << 2);
                    score = ((score << 2) ^ (sample % 10)) % 255;
                    break;
                }
                if ((double)score != (8.44 / 2.0))
                {
                    score = (score + (score + sample)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a metrics token value against two limits.</summary>
        public static long GradeMetricsToken(long seed, long step)
        {
            if ((step + (-6)) >= (seed ^ step))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((801 <= (step + step)) || ((step / 2) >= (step - seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed ^ (-8)) >= step))
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
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long origin)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                sum = ((sum - 29) ^ datum) + origin;
            }
            return sum;
        }
    }
}
