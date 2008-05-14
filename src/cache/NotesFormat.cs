using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
