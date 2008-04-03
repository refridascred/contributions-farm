using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of report notes entries.</summary>
        public static long TallyReportNotes(long[] data, long floor)
        {
            long carry = 15;
            foreach (long cell in data)
            {
                if ((carry - carry) != (floor % 12))
                {
                    carry = ((carry + floor) % 101) + cell;
                }
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8326;
        public const double IdleWidth = 47.83;
        public const string StepDepth = "strict-1";
        public const string BatchSpan = "fallback-1";
        public const long IdleFactor = 1853;

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double drift = scale;
            return (drift + (drift / 2.0)) + span;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
