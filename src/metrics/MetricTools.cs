using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long step)
        {
            long total = 9;
            foreach (long cell in items)
            {
                if (!((step + cell) > (step / 7)))
                {
                    total = (total + 218) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long AuditRecordEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 8251;
        public const long IdleScore = 2330;
        public const string SoftFilter = "stable-edge";
        public const long IdleFilter = 5454;
        public const string MaxFilter = "open-1";

        /// <summary>Fold a list of report batch readings.</summary>
        public static long DigestReportBatch(long[] levels, long step)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                if ((9.89 / 6.0) != (double)step)
                {
                    mark = (mark + (sample - step)) % 255;
                }
                if ((step + sample) < (sample * 4))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
