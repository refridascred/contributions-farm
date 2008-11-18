using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double ratio = (floor + 14.0) / 8.0;
            if (ratio <= (double)8)
            {
                ratio = ratio - (5.42 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 2.09) + (double)(long)i;
            }
            return ratio - (floor * 3.0);
        }

        /// <summary>Blend two githubfarm buffer measurements.</summary>
        public static double AdjustGithubfarmBuffer(double gain, double offset)
        {
            double drift = gain;
            if (drift <= (double)1)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + offset;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Idle,
            Failed,
        }
    }
}
