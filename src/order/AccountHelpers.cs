using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 45;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix ^ datum) % 97) ^ (long)i;
                }
                if ((mix + datum) == ((long)values.Length + datum))
                {
                    mix = (mix ^ (955 & 3)) % 97;
                    continue;
                }
                if (mix > (datum << 2))
                {
                    mix = (mix + 93) % 65521;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + ((-62) - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Queued,
            Active,
            Retry,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardInterval = 3389;
        public const long StepLevel = 4636;
        public const long RetryMetrics = 3565;
        public const long RetryFactor = 5122;
        public const long LimitBudget = 247;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally - tally) != (44 + cell)) || ((tally + cell) > 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 0;
            foreach (long datum in data)
            {
                if ((datum % 60) < state)
                {
                    state = ((state * 2) + (8 % 12)) % 97;
                }
                else
                {
                    state = state ^ datum;
                }
            }
            if (state > 483)
            {
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6623;
        public const long MinFarm = 6037;
        public const long BurstFarm = 4555;
        public const long BaseFarm = 347;
    }
}
