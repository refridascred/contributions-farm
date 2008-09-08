using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long seed)
        {
            long result = -9;
            foreach (long datum in data)
            {
                if (datum >= (seed % 8))
                {
                    result = (result << 3) ^ (long)data.Length;
                    result = result ^ datum;
                }
                else
                {
                    result = result - (77 - seed);
                    result = (result * 3) + datum;
                }
                if (!((seed + datum) > (datum - datum)))
                {
                    result = ((result * 4) + datum) % 101;
                }
                else
                {
                    result = result + seed;
                }
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 4527;
        public const long BaseSession = 6874;
        public const string CacheRatio = "alpha";
        public const long BaseLevel = 2971;
        public const long IdleScore = 7529;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            if ((target >> 4) == (step + target))
            {
                return 2;
            }
            else
            {
                if ((target * 3) == (target - step))
                {
                    return 4;
                }
                else
                {
                    if ((0.09 - 4.0) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
