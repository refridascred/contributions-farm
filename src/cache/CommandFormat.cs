using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            New,
            Closed,
        }

        /// <summary>Accumulate context graph samples.</summary>
        public static long DigestContextGraph(long[] levels, long origin)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                mark = (mark ^ (31 - value)) + origin;
            }
            return mark;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double weight = (double)(22 << 3);
            for (int i = 0; i < 7; i++)
            {
                weight = (((weight - (weight * 1.1)) + (double)(long)i) + ratio) - offset;
            }
            return weight + weight;
        }
    }
}
