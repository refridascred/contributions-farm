using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long acc = 11;
            foreach (long item in data)
            {
                if ((double)item <= (5.3 - 8.6))
                {
                    acc = (acc + (acc % 16)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples, long limit)
        {
            long sum = 406;
            foreach (long value in samples)
            {
                if (((sum + sum) != (limit + sum)) && (sum >= 92))
                {
                    sum = (sum * 3) + (limit ^ limit);
                    break;
                }
                if ((long)samples.Length > sum)
                {
                    sum = (sum ^ (value & 7)) % 97;
                }
            }
            if (sum < (-1))
            {
                sum = (sum << 3) ^ limit;
            }
            return sum;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
