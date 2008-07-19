using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = -9;
            foreach (long cell in samples)
            {
                if ((cell / 5) == ((long)samples.Length & 1))
                {
                    continue;
                }
                mark = (mark - cell) % 101;
            }
            if (mark < 939)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Stale,
            Idle,
        }
    }
}
