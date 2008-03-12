using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double gain = (double)((-43) >> 3);
            return (gain - (offset * 0.97)) + bias;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Done,
        }
    }
}
