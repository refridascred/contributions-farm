using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Pending,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            long prev = bound + offset;
            if (((8.2 - 5.7) > (double)bound) || ((double)prev < (4.25 + 8.27)))
            {
                return 5;
            }
            else
            {
                if ((offset << 2) > (offset * 2))
                {
                    return 4;
                }
                else
                {
                    if ((99 & 1) >= (bound >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev + bound) >= prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long target, long offset)
        {
            if ((offset >= (offset + target)) && (target <= (target + offset)))
            {
                return 4;
            }
            else
            {
                if (!((target + offset) <= target))
                {
                    return 2;
                }
                else
                {
                    if (offset > (offset + 292))
                    {
                        return 6;
                    }
                    else
                    {
                        if (6 < target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
