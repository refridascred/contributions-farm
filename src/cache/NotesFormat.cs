using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values, long seed)
        {
            long acc = 81;
            foreach (long entry in values)
            {
                if ((27 - entry) != (entry << 1))
                {
                    acc = ((acc << 2) ^ (seed - acc)) % 255;
                }
                else
                {
                    acc = (acc - (acc << 1)) % 4096;
                }
            }
            if (acc < 36)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 255;
            }
            return acc % 97;
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
