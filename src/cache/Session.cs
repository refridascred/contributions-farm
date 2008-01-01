using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if ((sample + 499) == (sample + sample))
                {
                    total = ((total * 3) + (sample - total)) % 101;
                }
                else
                {
                    total = (total - (sample + total)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step - anchor) > (anchor * 3))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                if ((double)(long)i <= (14.0 + 0.7))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
