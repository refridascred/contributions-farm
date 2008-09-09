using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context token entries that pass the check.</summary>
        public static long AuditContextTokenHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)entry >= 0.75) && (((1.59 * 14.0) <= (double)entry) || (entry > 46)))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Ready,
            Queued,
            Locked,
        }
    }
}
