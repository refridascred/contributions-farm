using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1185;
        public const string BatchRecord = "local-edge";
        public const string MinRecord = "cached";
        public const double StepRecord = 14.3;
        public const long LimitScore = 8278;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double gain2 = bias + bias;
            if (gain2 >= (bias - gain2))
            {
                gain2 = (gain2 - gain2) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + 11.0) + (double)(long)i;
            }
            return gain2 - (double)891;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            New,
            Done,
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long MeasureToolsCounterHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(((datum + hits) >= 972) && ((datum & 1) > (hits * 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
