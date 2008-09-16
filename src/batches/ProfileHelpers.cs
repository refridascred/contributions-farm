using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i >= (5.4 + 11.0))
                {
                    sum = sum + (seed - sum);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
