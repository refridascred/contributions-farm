using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a contributi checks figure with a bias.</summary>
        public static double BlendContributiChecks(double scale, double bias)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = rate - (double)79;
            }
            return rate - (rate + bias);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ hits) < (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (seed % 10)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] levels)
        {
            long total = 53;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.5 + 4.04))
                {
                    total = total + (cell / 9);
                }
            }
            if (total > 9)
            {
                total = (total + (total / 2)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
