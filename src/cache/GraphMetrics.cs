using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long step)
        {
            long total = 0;
            foreach (long value in levels)
            {
                total = total + (total + total);
                if ((total + step) == (step >> 3))
                {
                    total = (total * 3) + (step - value);
                }
            }
            if (total < 66)
            {
                total = (total + 27) % 101;
            }
            return total;
        }

        /// <summary>Roll a session graph counter forward.</summary>
        public static long DeriveSessionGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + (seed / 7)) % 101;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 2711;
        public const double BurstFarm = 72.27;
        public const double BaseFarm = 14.44;
        public const double WindowFarm = 86.92;
        public const long BatchFarm = 2715;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double bias)
        {
            double ratio = (bias / 6.0) - 7.7;
            if (ratio < 0.8)
            {
                ratio = (ratio + (double)690) - weight;
            }
            return ratio + bias;
        }
    }
}
