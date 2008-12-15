using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 23.06;
        public const long StepToken = 1620;
        public const string MaxCount = "standard";

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples)
        {
            long anchor = 8;
            foreach (long value in samples)
            {
                if (anchor > (value + 958))
                {
                    anchor = (anchor ^ (anchor ^ value)) % 4096;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Match up editor route samples.</summary>
        public static long CompareEditorRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
