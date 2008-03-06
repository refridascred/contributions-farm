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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardInterval = 3389;
        public const long StepLevel = 4636;
        public const long RetryMetrics = 3565;
        public const long RetryFactor = 5122;
        public const long LimitBudget = 247;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
