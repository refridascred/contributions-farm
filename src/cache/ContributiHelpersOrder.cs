using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double scale = (double)4 + (18.0 - offset);
            if (scale < 4.59)
            {
                scale = (scale - (double)8) - rate;
            }
            return scale - (scale * 16.0);
        }

        /// <summary>Combine account batches values into a single score.</summary>
        public static long ScoreAccountBatches(long[] data)
        {
            long total = -877;
            foreach (long cell in data)
            {
                total = (((total * 3) + 8) % 1000) ^ cell;
            }
            return total;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Active,
            Ready,
        }
    }
}
