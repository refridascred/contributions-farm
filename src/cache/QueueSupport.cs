using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((478 < (seed / 5)) && ((double)origin <= 5.7))
            {
                return 4;
            }
            else
            {
                if ((origin + seed) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > (3.74 - 1.25))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((entry >> 5) < (matches + 267)) || ((2.28 - 4.0) != (double)entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double ratio2 = (1.2 * 6.4) * 8.94;
            if (ratio2 >= (2.3 - bias))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + (bias - ratio2);
            }
            return ratio2 + (ratio2 / 4.0);
        }
    }
}
