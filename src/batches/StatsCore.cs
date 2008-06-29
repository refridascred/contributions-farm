using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long FoldContributiSchema(long[] levels, long step)
        {
            long total = 870;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = total ^ ((long)i + step);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + (total % 7)) + (long)i2;
                    total = (total + (total ^ 8)) % 255;
                }
                if (!((double)reading <= 2.87))
                {
                    total = total ^ reading;
                }
            }
            if (total < 8)
            {
                total = (total ^ (34 >> 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((7.81 - 7.12) != (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seen > (double)1) || ((2.46 / 9.0) <= (double)seen))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 217;
        public const long RetryLayout = 5428;
        public const double IdleLayout = 52.93;
        public const long MinLayout = 7192;
        public const double LimitLayout = 86.9;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Stale,
            Paused,
            Idle,
        }
    }
}
