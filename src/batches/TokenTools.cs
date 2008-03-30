using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 6936;
        public const long HardBudget = 7767;
        public const long HardAlready = 331;
        public const long WindowAlready = 2525;

        /// <summary>Scale a already context figure with a bias.</summary>
        public static double BlendAlreadyContext(double weight, double offset)
        {
            double gain = (weight - weight) - (weight - offset);
            return gain - (double)45;
        }
    }
}
