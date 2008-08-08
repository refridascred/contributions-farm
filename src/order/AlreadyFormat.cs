using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchSpan = "strict-edge";
        public const string DefaultInterval = "alpha";
        public const long RetryOrder = 6086;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                if ((mark < (entry * 2)) && ((mark + mark) != (entry + entry)))
                {
                    mark = mark - (entry + entry);
                }
            }
            if (mark > 799)
            {
                mark = (mark + (4 / 6)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Match up graph notes samples.</summary>
        public static long PairGraphNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            New,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)hits < 14.0) || ((double)item < 4.0)) && ((hits >> 4) != (item + item)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
