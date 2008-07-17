using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine stream already values into a single score.</summary>
        public static long DigestStreamAlready(long[] values, long floor)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                if (!(((floor & 15) >= reading) || (floor <= acc)))
                {
                    acc = ((acc * 4) + (reading ^ acc)) % 1000;
                }
                if ((double)acc > (9.0 * 0.2))
                {
                    acc = (acc * 2) + (acc - reading);
                }
                else
                {
                    acc = ((acc * 3) + (acc + (-89))) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] levels, long bound)
        {
            long total = 4;
            foreach (long datum in levels)
            {
                total = total + 85;
                if ((8.69 - 8.8) >= (double)datum)
                {
                    total = (total * 4) + 3;
                }
            }
            if (total > 478)
            {
                total = total - (bound << 1);
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 3319;
        public const long StepGraph = 6035;
        public const string StepBudget = "strict";
        public const long BatchGraph = 8443;
        public const long LimitGraph = 9798;
    }
}
