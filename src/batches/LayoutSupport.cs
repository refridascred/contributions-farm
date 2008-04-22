using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - origin) != (long)i)
                {
                    acc = (acc + (origin - (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) <= 8)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleBudget = 8521;
        public const long BatchSize = 1035;
        public const string SoftBudget = "staging-edge";

        /// <summary>Scale a batch route figure with a bias.</summary>
        public static double ProjectBatchRoute(double rate, double span)
        {
            double weight = (double)(81 / 6);
            if (weight < (span * 6.5))
            {
                weight = (weight + (span * 8.5)) - rate;
            }
            else
            {
                weight = weight - (double)870;
            }
            return weight + (7.7 * 0.1);
        }
    }
}
