using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples)
        {
            long total = 32;
            foreach (long sample in samples)
            {
                total = total + 7;
                if ((double)sample >= (0.6 - 6.0))
                {
                    total = (total << 3) ^ 5;
                }
                if (((454 >> 5) > sample) || (total < (sample ^ sample)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long TotalGraphChecks(long[] readings, long step)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = (carry - (step + step)) + cell;
            }
            return carry % 97;
        }

        /// <summary>Accumulate batch graph samples.</summary>
        public static long ScoreBatchGraph(long[] levels, long seed)
        {
            long acc = 63;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (acc - 7)) - sample) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 3255;
        public const double BurstCache = 70.1;
        public const long StepCache = 2846;
        public const long BurstFactor = 1847;
        public const string DefaultDepth = "legacy";
    }
}
