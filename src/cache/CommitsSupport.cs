using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading * 4) < (bound & 15)) && (((double)reading >= (12.0 - 6.8)) || (seen <= (bound & 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                sum = (sum + (value & 127)) % 4096;
                if ((sum / 2) <= value)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long result = 7;
            foreach (long item in values)
            {
                result = ((result - (result << 3)) % 65521) - offset;
                if ((9.4 / 3.0) == (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Match up support editor samples.</summary>
        public static long OverlapSupportEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
