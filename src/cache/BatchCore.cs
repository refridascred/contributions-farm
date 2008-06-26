using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((81 + entry) >= (seen - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                anchor = anchor - datum;
            }
            if (anchor < 707)
            {
                anchor = anchor + (anchor << 2);
            }
            return anchor % 4096;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Locked,
        }
    }
}
