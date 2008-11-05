using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if (!((limit & 7) > limit))
            {
                return 1;
            }
            else
            {
                if ((0.69 - 2.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double mean = (ratio + offset) - (double)44;
            if (mean < offset)
            {
                mean = mean + (mean / 4.0);
            }
            return mean - 16.0;
        }

        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long MeasureContributiEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 8) > (value & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long cur = limit - step;
            if ((limit & 127) > (cur + limit))
            {
                return 3;
            }
            else
            {
                if ((step % 64) <= (cur + limit))
                {
                    return 2;
                }
                else
                {
                    if ((step << 2) <= (limit - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = 11;
            foreach (long entry in data)
            {
                state = ((state << 3) ^ (state + entry)) % 101;
            }
            return state % 4096;
        }
    }
}
