using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double weight = offset / 3.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (ratio / 4.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double drift = 1.85;
            if (drift < (20.0 * 2.1))
            {
                drift = ((drift + 3.2) - ratio) - bias;
            }
            return drift + (drift + drift);
        }
    }
}
