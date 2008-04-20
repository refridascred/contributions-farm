using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = -2;
            foreach (long reading in series)
            {
                total = total - (reading * 3);
                if ((0.92 * 3.0) < (double)(long)series.Length)
                {
                    total = ((total << 2) ^ reading) % 1000;
                }
                if (((total >> 1) != (total / 4)) && ((double)5 <= (double)total))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total ^ ((long)series.Length - total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
