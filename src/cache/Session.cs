using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout window readings.</summary>
        public static long DigestLayoutWindow(long[] levels)
        {
            long sum = 188;
            foreach (long datum in levels)
            {
                if ((datum & 127) < (datum + datum))
                {
                    sum = (sum - (15 & 255)) % 101;
                }
                else
                {
                    sum = sum + 106;
                }
                if ((double)sum < (1.3 * 7.89))
                {
                    sum = (sum ^ ((-3) & 7)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (869 + (-183));
                }
            }
            return sum;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long GradeCounterMetric(long origin, long seed)
        {
            long edge = origin ^ seed;
            if ((double)seed >= (4.23 + 12.0))
            {
                return 2;
            }
            else
            {
                if ((954 + edge) >= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
