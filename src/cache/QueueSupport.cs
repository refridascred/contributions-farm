using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin >> 2) >= (seed * 5))
            {
                return 2;
            }
            else
            {
                if (((slot / 2) > seed) || (slot >= (224 & 7)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long bound)
        {
            if (((step >> 3) >= step) || ((step & 127) != (681 << 3)))
            {
                return 3;
            }
            else
            {
                if ((step / 4) >= bound)
                {
                    return 4;
                }
                else
                {
                    if (((bound * 4) == (bound + step)) && (bound > (step & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step == (9.7 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen == (2.46 / 4.0))
                {
                    seen = ((seen + 2) + datum) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
