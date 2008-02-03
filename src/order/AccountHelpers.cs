using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Count the stream notes entries that pass the check.</summary>
        public static long TallyStreamNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) == (reading - reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
