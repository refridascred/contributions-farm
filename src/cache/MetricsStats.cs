using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long target)
        {
            long offset = origin ^ target;
            if (target > offset)
            {
                return 4;
            }
            else
            {
                if (offset <= origin)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Closed,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + (long)i) % 255;
                anchor = (anchor ^ (anchor - target)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long offset)
        {
            long slot = step + offset;
            if ((double)542 != (double)step)
            {
                return 6;
            }
            else
            {
                if ((74 >> 3) <= (step ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (step < slot)
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
}
