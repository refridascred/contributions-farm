using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4267;
        public const long WindowCache = 8230;
        public const string BatchSize = "standard";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                if (!(sample <= (anchor + sample)))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (anchor % 5)) % 65521;
                }
                if (anchor > 60)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
