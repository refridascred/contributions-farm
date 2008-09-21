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

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Retry,
            Closed,
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
