using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = (((score << 2) ^ (value / 4)) % 101) + step;
            }
            return score % 65521;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= (8.95 - 15.0))
            {
                bias = bias - (7.42 / 4.0);
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (4.18 * 8.17)) + (double)(long)i;
            }
            return bias + ratio;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ 217) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
