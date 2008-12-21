using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches >= (7.69 / 4.0))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 44.12;
        public const double StepTools = 13.42;
        public const long SoftBudget = 4601;
        public const long MaxTools = 5929;
        public const double HardTools = 76.58;
    }
}
