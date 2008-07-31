using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double ratio = 0.1 - bias;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)(long)i) - floor;
            }
            return ratio + bias;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Paused,
            Retry,
            New,
        }
    }
}
