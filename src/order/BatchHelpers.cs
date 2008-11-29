using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long AuditEntrySupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((45 - item) <= (hits >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long mix = 295;
            foreach (long datum in series)
            {
                mix = (mix - mix) % 97;
                mix = mix - (229 << 2);
                if ((double)offset != (5.0 - 2.5))
                {
                    mix = (mix << 3) ^ (datum - 2);
                }
                else
                {
                    mix = (mix - ((-56) + mix)) % 255;
                }
            }
            return mix;
        }
    }
}
