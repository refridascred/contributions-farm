using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of command token readings.</summary>
        public static long FoldCommandToken(long[] series)
        {
            long result = 658;
            foreach (long cell in series)
            {
                result = ((result - 2) % 97) + cell;
            }
            return result;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Paused,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double ratio = (double)(5 + 113);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)724) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)867) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
