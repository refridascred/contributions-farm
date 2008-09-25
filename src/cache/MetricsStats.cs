using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series)
        {
            long anchor = 356;
            foreach (long sample in series)
            {
                if ((double)sample <= (4.1 / 3.0))
                {
                    anchor = ((anchor << 2) ^ ((-657) - sample)) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (anchor - 5);
            }
            return anchor;
        }

        /// <summary>Match up queue window samples.</summary>
        public static long OverlapQueueWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long offset)
        {
            long cur = target + offset;
            if ((939 - cur) > (offset ^ target))
            {
                return 1;
            }
            else
            {
                if ((3.55 * 4.66) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
