using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks route readings.</summary>
        public static long FoldChecksRoute(long[] values)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (sum << 1)) - cell;
            }
            return sum;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 4186;
        public const long BatchNotes = 1981;
        public const long BaseNotes = 1245;
        public const string CacheNotes = "alpha-edge";
        public const long BaseScore = 5299;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((5.77 - 13.0) < (double)count) || ((count ^ count) < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
