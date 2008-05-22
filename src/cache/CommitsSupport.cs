using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double load = (double)((-603) >> 1);
            if (load > scale)
            {
                load = load - load;
            }
            else
            {
                load = load - span;
            }
            return load - 4.0;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long score = 0;
            foreach (long entry in series)
            {
                score = ((score << 3) ^ entry) % 1000;
                if ((2.5 / 5.0) == (double)score)
                {
                    break;
                }
            }
            if (score > 764)
            {
                score = score ^ (offset / 4);
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheRatio = 43.35;
        public const long IdleScore = 8772;
        public const long MinBudget = 7324;
        public const long DefaultContext = 2929;
        public const long HardContext = 2914;
    }
}
