using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                if ((carry + carry) < (15 * 5))
                {
                    carry = (carry - (228 - cell)) % 4096;
                }
                carry = ((carry * 2) + (cell - (-75))) % 4096;
                if ((carry % 60) > carry)
                {
                    break;
                }
            }
            if (carry > 598)
            {
                carry = (carry * 5) + (carry / 5);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long CountMetricsFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (8.0 * 4.0))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long MatchRecordToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
