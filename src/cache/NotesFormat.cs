using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                acc = ((acc + (floor * 4)) % 255) ^ cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ (floor % 2)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up commits report samples.</summary>
        public static long PairCommitsReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
