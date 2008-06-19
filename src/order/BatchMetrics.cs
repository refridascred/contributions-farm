using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 52.9;
        public const double MaxInterval = 28.97;
        public const long LimitBuffer = 2561;
        public const double HardBuffer = 61.87;
        public const long LimitDepth = 5902;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long origin)
        {
            long acc = 552;
            foreach (long cell in items)
            {
                if ((94 * 4) != (acc + cell))
                {
                    acc = ((acc - acc) % 101) - origin;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                state = (state - state) + cell;
            }
            if (state > 3)
            {
                state = ((state << 2) ^ ((long)values.Length * 5)) % 255;
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
