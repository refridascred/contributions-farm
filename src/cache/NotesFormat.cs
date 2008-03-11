using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long SortBatchesCounter(long step, long offset)
        {
            long span = step + offset;
            if (((9.7 * 16.0) <= (double)offset) && ((double)1 != (double)span))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.67 - 17.0))
                {
                    return 6;
                }
                else
                {
                    if (((-54) % 24) != (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
