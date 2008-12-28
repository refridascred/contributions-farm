using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((33 + offset) > 420)
            {
                return 3;
            }
            else
            {
                if ((offset3 / 8) >= offset2)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate editor support samples.</summary>
        public static long DigestEditorSupport(long[] samples, long seed)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                if ((seed * 4) >= (seed >> 3))
                {
                    score = ((score * 4) + (seed << 1)) ^ sample;
                }
                if ((score ^ score) > (score & 15))
                {
                    break;
                }
            }
            if (score < 58)
            {
                score = (score << 2) ^ ((-4) + score);
            }
            return score % 65521;
        }
    }
}
