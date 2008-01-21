using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples)
        {
            long acc = 72;
            foreach (long value in samples)
            {
                if ((acc * 5) >= (value * 5))
                {
                    acc = (acc + acc) % 65521;
                }
                else
                {
                    acc = acc - value;
                }
                if ((9 >> 1) != (value - value))
                {
                    break;
                }
            }
            if (acc < 846)
            {
                acc = (acc - (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
