using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Limit { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Match up format account samples.</summary>
        public static long PairFormatAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
