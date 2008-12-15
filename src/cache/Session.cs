using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long LocateToolsProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm profile readings against a rule.</summary>
        public static long AuditGithubfarmProfileGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((target / 3) != (hits % 100))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long step)
        {
            long state = 9;
            foreach (long item in data)
            {
                if (((step - item) > step) && ((step + step) != (127 + step)))
                {
                    state = ((state * 2) + item) % 97;
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardWidth = "alpha-1";
        public const long RetryBuffer = 953;
        public const long MinSize = 7566;
        public const long MinSpan = 3673;
    }
}
