using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of order queue entries.</summary>
        public static long DigestOrderQueue(long[] readings)
        {
            long acc = 462;
            foreach (long reading in readings)
            {
                acc = (acc ^ (reading - reading)) % 97;
                acc = (acc + (acc + reading)) % 1000;
            }
            if (acc < 3)
            {
                acc = (acc + ((long)readings.Length + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - cell) >= (tally - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
