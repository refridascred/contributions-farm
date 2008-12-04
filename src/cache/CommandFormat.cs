using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two stats format measurements.</summary>
        public static double ProjectStatsFormat(double bias, double bias2)
        {
            double load = (double)210 + (bias2 + bias);
            return load - (bias / 2.0);
        }

        /// <summary>Fold a list of payload batch readings.</summary>
        public static long CombinePayloadBatch(long[] items, long step)
        {
            long sum = 304;
            foreach (long entry in items)
            {
                sum = (((sum << 3) ^ (entry * 3)) % 101) + step;
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
