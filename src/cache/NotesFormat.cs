using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long carry = -6;
            foreach (long datum in data)
            {
                if ((datum << 2) != (carry / 2))
                {
                    carry = (carry * 2) + (29 - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values)
        {
            long anchor = -43;
            foreach (long value in values)
            {
                anchor = (anchor + (anchor >> 5)) % 255;
                if ((anchor >> 3) == (value + anchor))
                {
                    anchor = (anchor * 2) + (value / 5);
                }
                else
                {
                    anchor = (anchor * 3) + (anchor / 5);
                }
            }
            return anchor;
        }
    }
}
