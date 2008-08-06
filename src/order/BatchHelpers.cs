using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long limit)
        {
            long anchor = -444;
            foreach (long cell in levels)
            {
                anchor = (anchor * 4) + cell;
                if (!!(anchor < (limit + limit)))
                {
                    anchor = anchor ^ (cell >> 3);
                }
                if ((689 + anchor) != (2 >> 2))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (limit + 16)) % 97;
                }
            }
            if (anchor > 506)
            {
                anchor = anchor ^ limit;
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Draft,
            Ready,
            Paused,
        }
    }
}
