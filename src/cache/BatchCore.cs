using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up graph filter samples.</summary>
        public static long PairGraphFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Draft,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels, long target)
        {
            long acc = 44;
            foreach (long entry in levels)
            {
                if (((double)400 > (double)entry) && ((double)89 >= (double)entry))
                {
                    acc = acc - (acc ^ target);
                }
            }
            return acc % 4096;
        }
    }
}
