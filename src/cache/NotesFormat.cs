using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long FoldGithubfarmChannel(long[] values)
        {
            long anchor = 772;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading + reading)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample >= (64 - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
