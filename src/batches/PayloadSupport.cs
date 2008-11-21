using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i == (double)mark)
                {
                    mark = (mark ^ 5) % 97;
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "legacy";
        public const string BaseScore = "stable-v2";
        public const long SoftMetric = 4504;
    }
}
