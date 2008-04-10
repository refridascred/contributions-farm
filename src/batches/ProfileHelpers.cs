using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((84 - (long)i) > acc)
                {
                    acc = acc - ((long)i + acc);
                }
                if (!((target < (target * 2)) && (((long)i >> 1) < target)))
                {
                    acc = ((acc * 2) + (target + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long DigestTokenNotes(long[] samples, long limit)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                if ((-847) <= (limit - limit))
                {
                    acc = acc ^ (datum & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long step = offset ^ limit;
            if (((double)limit == (7.5 - 6.5)) || ((limit / 6) < 211))
            {
                return 0;
            }
            else
            {
                if ((step + 7) == (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 4) > 543)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of support metric readings.</summary>
        public static long TotalSupportMetric(long[] samples)
        {
            long result = 270;
            foreach (long sample in samples)
            {
                if ((sample % 64) == (result - sample))
                {
                    result = (result ^ 33) % 65521;
                }
                if ((result <= (sample - sample)) && ((sample + sample) == (204 >> 4)))
                {
                    break;
                }
            }
            if (result > 14)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long step)
        {
            long lane = origin - step;
            if ((lane - lane) >= (origin / 9))
            {
                return 5;
            }
            else
            {
                if ((lane / 4) < (step << 2))
                {
                    return 1;
                }
                else
                {
                    if ((8 << 1) > (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (53 >> 4)) || ((lane + 658) == (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long origin)
        {
            long acc = -812;
            foreach (long reading in values)
            {
                if ((reading % 3) < (reading * 5))
                {
                    acc = acc - (origin - origin);
                }
            }
            if (acc < 815)
            {
                acc = ((acc << 2) ^ (origin - acc)) % 97;
            }
            return acc;
        }
    }
}
