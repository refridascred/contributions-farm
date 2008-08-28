using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = (ratio - (offset * 5.61)) + gain;
            }
            else
            {
                ratio = ratio + (offset * 0.2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (2.0 / 9.0)) + (double)(long)i;
            }
            return ratio - 9.9;
        }

        /// <summary>Count stream account pairs that satisfy a relation.</summary>
        public static long MatchStreamAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstTimeout = 616;
        public const double HardQueue = 14.62;
        public const long DefaultFactor = 8386;
        public const string IdleQueue = "open";
        public const long DefaultBudget = 1951;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Active,
            Pending,
            Draft,
            Synced,
        }
    }
}
