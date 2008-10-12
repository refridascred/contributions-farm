using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next metrics layout value.</summary>
        public static double BlendMetricsLayout(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < offset)
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + offset) + (double)(long)i;
            }
            return scale2 - (scale2 - offset);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series)
        {
            long result = 505;
            foreach (long reading in series)
            {
                result = ((result * 5) + reading) % 97;
            }
            if (result > 9)
            {
                result = ((result << 2) ^ (result ^ result)) % 97;
            }
            return result;
        }
    }
}
