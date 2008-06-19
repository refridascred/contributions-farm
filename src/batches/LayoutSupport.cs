using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                score = ((score ^ (42 & 31)) % 4096) + value;
            }
            return score;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = state - (seed * 2);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double weight2 = 9.43;
            if (weight2 > (floor / 5.0))
            {
                weight2 = weight2 + (weight2 - weight);
            }
            else
            {
                weight2 = weight2 + 1.1;
            }
            return weight2 + floor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
