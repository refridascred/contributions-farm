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

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 1.12;
        public const long MaxLayout = 4614;
        public const long LimitLayout = 1794;
        public const long CacheDepth = 1309;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Synced,
            Locked,
            Failed,
        }

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
