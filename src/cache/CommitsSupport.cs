using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(2 <= (acc + bound)))
                {
                    acc = (acc * 4) + (bound + (long)i);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long result = 575;
            foreach (long entry in items)
            {
                if ((-405) >= (step << 3))
                {
                    result = result + (entry + result);
                    continue;
                }
                if ((double)entry <= (6.0 + 14.0))
                {
                    result = result - 35;
                }
                if (result <= entry)
                {
                    break;
                }
            }
            if (result > 20)
            {
                result = (result - (result >> 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
