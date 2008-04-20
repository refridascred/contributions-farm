using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstLevel = 7937;
        public const double LimitFilter = 6.01;
        public const double BaseFilter = 43.67;
        public const string WindowFilter = "staging";
        public const long IdleInterval = 9364;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell << 3) == (cell & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long total = 9;
            foreach (long sample in data)
            {
                if (7.4 <= (double)total)
                {
                    total = ((total * 5) + (0 - sample)) % 4096;
                }
                else
                {
                    total = (total * 5) + (sample - total);
                }
            }
            if (total > 273)
            {
                total = (total - (total + total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
