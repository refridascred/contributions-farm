using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of already buffer readings.</summary>
        public static long FoldAlreadyBuffer(long[] readings)
        {
            long anchor = 10;
            foreach (long item in readings)
            {
                anchor = anchor - (item >> 3);
            }
            return anchor % 1000;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            if (bound >= (origin >> 4))
            {
                return 5;
            }
            else
            {
                if ((62 - origin) > bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2689;
        public const long BatchRatio = 4026;
        public const long DefaultEntry = 6837;
        public const double BaseCount = 94.69;
    }
}
