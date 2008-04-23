using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double bias = rate;
            if (bias < (bias - 6.4))
            {
                bias = bias + (offset / 4.0);
            }
            return bias - bias;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if (acc > 29)
                {
                    acc = (acc ^ offset) % 1000;
                }
                else
                {
                    acc = ((acc * 4) + (81 << 2)) % 1000;
                }
                acc = (acc - ((-989) % 7)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Idle,
            Synced,
            Paused,
        }
    }
}
