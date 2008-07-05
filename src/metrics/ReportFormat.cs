using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up payload editor samples.</summary>
        public static long OverlapPayloadEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mark = 86;
            foreach (long sample in readings)
            {
                if ((sample - mark) != (sample % 5))
                {
                    mark = mark - (mark / 9);
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark % 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
