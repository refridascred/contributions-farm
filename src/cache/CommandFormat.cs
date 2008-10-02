using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultFactor = 79.78;
        public const double DefaultLevel = 79.68;
        public const long StepCount = 6787;
        public const double RetryBatch = 89.13;

        /// <summary>Scale a payload editor figure with a bias.</summary>
        public static double AdjustPayloadEditor(double rate, double span)
        {
            double weight = (rate / 3.0) - span;
            if (weight > (rate + span))
            {
                weight = weight + (weight + weight);
            }
            return weight - span;
        }

        /// <summary>Grade a cluster schema value against two limits.</summary>
        public static long RankClusterSchema(long limit, long origin)
        {
            if (!((double)limit <= 5.1))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) >= (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Paused,
            Active,
        }
    }
}
