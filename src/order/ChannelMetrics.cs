using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long WeighRecordCluster(long[] samples)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                if ((sum + value) >= value)
                {
                    sum = (sum + (860 ^ sum)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double gain = (weight + weight) * 5.0;
            if (gain < 3.68)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (floor + 0.8);
            }
            return gain + gain;
        }
    }
}
