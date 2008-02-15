using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if ((676 & 255) > (state % 24))
                {
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    state = ((state + value) % 255) + (long)i;
                }
                if (((value - value) <= (-18)) && ((value << 1) > ((long)samples.Length % 12)))
                {
                    state = state - (state + offset);
                }
            }
            return state;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
