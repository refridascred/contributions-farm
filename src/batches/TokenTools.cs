using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Scale a graph farm figure with a bias.</summary>
        public static double BlendGraphFarm(double gain, double offset)
        {
            double scale = offset;
            if (scale >= offset)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (double)51;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + 4.5;
        }
    }
}
