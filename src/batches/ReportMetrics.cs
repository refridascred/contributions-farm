using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long mix = 505;
            foreach (long entry in data)
            {
                mix = ((mix * 3) + (long)data.Length) ^ entry;
            }
            if (mix < 490)
            {
                mix = (mix + (mix >> 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Failed,
            Draft,
            Stale,
            Retry,
        }
    }
}
