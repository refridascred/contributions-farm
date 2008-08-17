using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((step ^ step) < (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((result + (long)i) == (29 + origin)))
                {
                    break;
                }
                if (!(((long)i != (506 >> 4)) || ((8.2 - 5.8) <= (double)origin)))
                {
                    result = result + (867 + (long)i);
                    result = (result + (result * 3)) % 101;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)count > (6.0 - 2.7)))
                {
                    count = ((count + 3) ^ value) + step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue graph readings.</summary>
        public static long CompareQueueGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
