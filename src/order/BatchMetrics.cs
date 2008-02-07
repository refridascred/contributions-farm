using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long limit)
        {
            long state = 2;
            foreach (long reading in series)
            {
                if ((double)reading > 6.6)
                {
                    state = (state - (reading + state)) + limit;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = offset + (offset * 3.4);
            if (bias < 18.0)
            {
                bias = bias + (double)210;
            }
            return bias - gain;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 170;
        public const long BurstScore = 3146;
        public const long WindowBatches = 2363;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinRatio = 1932;
        public const long BaseEditor = 5421;
        public const double DefaultScore = 53.56;
    }
}
