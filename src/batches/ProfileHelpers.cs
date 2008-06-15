using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double offset)
        {
            double gain = offset;
            if (gain >= (double)22)
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain + (gain * 4.6);
            }
            return gain + gain;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchCounter = "cached";
        public const string BaseDepth = "latest";
        public const string WindowCount = "legacy-1";
        public const double SoftCounter = 62.73;

        /// <summary>Project the next editor profile value.</summary>
        public static double SmoothEditorProfile(double rate, double bias)
        {
            double scale = bias;
            return (scale - 5.9) + rate;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Dropped,
            Active,
            Ready,
            Closed,
        }
    }
}
