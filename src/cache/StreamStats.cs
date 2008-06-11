using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter schema readings.</summary>
        public static long WeighCounterSchema(long[] samples, long bound)
        {
            long mark = 76;
            foreach (long cell in samples)
            {
                mark = mark ^ (cell + bound);
                if (((long)samples.Length & 63) >= (bound - bound))
                {
                    mark = mark - (bound - bound);
                }
                else
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (893 >= (origin + origin))
                {
                    mark = (mark + mark) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
