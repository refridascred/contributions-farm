using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 3) > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of entry report entries.</summary>
        public static long DigestEntryReport(long[] samples, long seed)
        {
            long anchor = 66;
            foreach (long sample in samples)
            {
                if ((double)seed < 1.15)
                {
                    anchor = (anchor + (anchor / 9)) + sample;
                }
            }
            return anchor;
        }
    }
}
