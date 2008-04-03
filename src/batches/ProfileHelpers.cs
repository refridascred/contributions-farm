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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

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
