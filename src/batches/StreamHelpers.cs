using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine contributi session values into a single score.</summary>
        public static long DigestContributiSession(long[] samples)
        {
            long score = 70;
            foreach (long cell in samples)
            {
                score = ((score * 4) + (cell >> 5)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Dropped,
            Done,
            New,
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if ((1.4 / 4.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if ((target / 6) > 8)
                {
                    return 4;
                }
                else
                {
                    if ((offset <= target) && (target <= (offset << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)7 > (double)value)
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
