using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long step)
        {
            long offset = target + step;
            if (!(12.0 >= (double)step))
            {
                return 0;
            }
            else
            {
                if (target <= (target - step))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 7) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
