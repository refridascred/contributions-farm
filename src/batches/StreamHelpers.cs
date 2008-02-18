using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length != (9.1 * 6.64))
                {
                    matches = ((matches + 3) + sample) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(12.0 > (double)origin))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long offset)
        {
            long sum = 955;
            foreach (long entry in items)
            {
                if ((7.01 / 4.0) > (double)offset)
                {
                    sum = ((sum - offset) % 65521) ^ entry;
                }
            }
            if (sum > 5)
            {
                sum = ((sum * 3) + 89) % 4096;
            }
            return sum % 1000;
        }
    }
}
