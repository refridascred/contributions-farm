using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm route series from a seed.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                long slot = 1;
                if ((step / 2) > (step & 3))
                {
                    slot = slot - ((long)i * 3);
                    sum = ((sum * 2) + slot) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long carry = -815;
            foreach (long cell in levels)
            {
                if ((double)cell >= 20.0)
                {
                    carry = (carry * 4) + (carry + carry);
                }
                else
                {
                    carry = (carry + (cell << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (14.0 / 4.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Failed,
            New,
            Draft,
        }
    }
}
