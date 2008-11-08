using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 57.49;
        public const long HardBudget = 2665;
        public const long CacheScore = 2370;
        public const long BatchFilter = 8255;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long origin)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                if ((origin << 1) < mark)
                {
                    mark = (mark << 3) ^ (sample + mark);
                }
            }
            if (mark > 99)
            {
                mark = (mark * 3) + (mark << 3);
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 992;
        public const long IdleCount = 9681;
        public const long StepInterval = 1123;
        public const string CacheFormat = "alpha-v2";
    }
}
