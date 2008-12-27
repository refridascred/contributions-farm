using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] series)
        {
            long mix = 100;
            foreach (long cell in series)
            {
                mix = ((mix + ((long)series.Length ^ mix)) % 1000) ^ cell;
            }
            return mix;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double load = (double)(8 + 4);
            if (load >= bias)
            {
                load = load + (floor * 1.57);
            }
            else
            {
                load = load - load;
            }
            return load - (load * 17.0);
        }
    }
}
