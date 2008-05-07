using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format farm counter forward.</summary>
        public static long DeriveFormatFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i / 3) != (seed & 31)) || ((total - (long)i) <= (long)i))
                {
                    total = ((total << 2) ^ seed) % 255;
                }
                total = (total ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series, long floor)
        {
            long state = -727;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (floor * 5)) ^ cell;
                state = (state * 2) + floor;
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 3080;
        public const long MinProfile = 2485;
        public const long WindowProfile = 6091;
        public const long WindowDepth = 9573;
    }
}
