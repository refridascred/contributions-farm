using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ floor) != (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((-9) & 15) < ((long)i * 3))
                {
                    mark = mark - offset;
                    mark = (mark + 60) % 4096;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
