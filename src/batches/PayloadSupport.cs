using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Pending,
            Done,
            Queued,
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long DeriveEditorWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor << 3) ^ ((long)i >> 1)) ^ (long)i2;
                    anchor = (anchor ^ (53 << 2)) % 255;
                }
                if (((long)i & 1) < bound)
                {
                    anchor = anchor - (anchor << 1);
                }
                else
                {
                    anchor = ((anchor << 3) ^ bound) % 4096;
                }
                anchor = (anchor - (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long AuditContributiTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) != (seen << 1))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
