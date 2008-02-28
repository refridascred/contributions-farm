using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double rate = weight;
            if (rate > bias)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + 18.0;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Failed,
            Dropped,
            Pending,
            Synced,
        }
    }
}
