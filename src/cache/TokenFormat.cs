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

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed & 255) >= (entry >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
