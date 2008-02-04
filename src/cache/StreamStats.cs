using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTimeout = "stable-1";
        public const long BaseTools = 981;
        public const long MinTools = 5934;
        public const long StepTools = 7092;

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double ratio = 8.64;
            return ((ratio - (double)4) + weight) + offset;
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long ScoreStreamPayload(long[] levels, long limit)
        {
            long anchor = 382;
            foreach (long entry in levels)
            {
                if (17.0 >= (double)anchor)
                {
                    anchor = (((anchor << 3) ^ anchor) + entry) + limit;
                }
                else
                {
                    anchor = (anchor << 2) ^ 10;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
