using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                mark = (((mark * 5) + (datum << 3)) % 65521) + step;
            }
            if (mark > 9)
            {
                mark = (mark * 3) + (763 << 1);
            }
            return mark % 1000;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "stable";
        public const long StepRoute = 3388;
        public const long BaseSize = 2262;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double gain = span + (span / 9.0);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (double)(-81)) - (double)(long)i) + weight;
            }
            return gain + (span * 16.0);
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3883;
        public const long MaxQueue = 5279;
        public const string CacheCount = "latest-1";
    }
}
