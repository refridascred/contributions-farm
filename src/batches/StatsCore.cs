using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = 2.5;
            return (weight - offset) + ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 911;
        public const long DefaultTools = 1314;
        public const long BatchTools = 9936;
        public const long DefaultSize = 4994;
        public const double MinSize = 24.32;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Locked,
        }
    }
}
