using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long step)
        {
            long step2 = target ^ step;
            if ((518 >= target) && ((step << 3) >= step2))
            {
                return 5;
            }
            else
            {
                if (!((step2 >> 3) == (step2 >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((10.0 / 7.0) <= (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long origin)
        {
            long anchor = 64;
            foreach (long value in series)
            {
                if ((value >> 4) <= anchor)
                {
                    anchor = ((anchor * 2) + (origin - origin)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first layout report entry that matches the target.</summary>
        public static long FindLayoutReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Synced,
            Draft,
        }
    }
}
