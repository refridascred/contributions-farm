using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long acc = -227;
            foreach (long reading in values)
            {
                acc = (acc + reading) % 255;
                acc = ((acc * 4) + (reading << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a already editor reading.</summary>
        public static double ProjectAlreadyEditor(double bias, double floor)
        {
            double scale = (double)(865 + (-40));
            if (scale <= (0.4 / 7.0))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Paused,
            Failed,
            Synced,
        }
    }
}
