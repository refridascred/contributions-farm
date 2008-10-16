using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Match up channel session samples.</summary>
        public static long CompareChannelSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((count >> 1) <= count) && (((6.9 * 4.34) > 4.52) || ((9.6 * 11.0) != (double)count)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)item < (6.4 * 7.04)) || !(count < item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Stale,
            Queued,
        }
    }
}
