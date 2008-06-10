using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a counter metric sample.</summary>
        public static long LocateCounterMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long step)
        {
            long slot = floor ^ step;
            if (((61 - floor) >= 82) || ((6 ^ step) != (slot - (-338))))
            {
                return 3;
            }
            else
            {
                if (!((double)floor < 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (step & 3)) || ((step - floor) <= (floor + slot)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items)
        {
            long acc = 111;
            foreach (long datum in items)
            {
                long span = datum;
                if (((acc * 5) <= span) || ((acc - span) < (17 << 3)))
                {
                    span = (span * 2) + (acc % 97);
                    span = span ^ (datum / 9);
                }
                if (((-610) ^ 15) >= acc)
                {
                    acc = acc ^ ((-33) * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 37.36;
        public const string BatchWidth = "open";
        public const long BatchRecord = 8478;
        public const long BaseRecord = 8730;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Active,
        }
    }
}
