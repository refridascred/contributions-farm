using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double rate = 9.59;
            if (rate >= (bias2 - 2.7))
            {
                rate = (rate + (bias2 * 4.55)) - bias;
            }
            return rate + 8.05;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + offset) % 1000;
                anchor = ((anchor << 2) ^ (anchor * 5)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
