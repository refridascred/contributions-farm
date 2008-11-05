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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (-2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double drift = (double)(86 - 607);
            if (drift <= (double)773)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift + rate;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target == (5.41 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((span - span) <= (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 / 2.0) == (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
