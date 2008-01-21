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

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] data, long step)
        {
            long mix = 1;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ (mix - reading);
                if ((390 + mix) != (61 - reading))
                {
                    mix = ((mix * 2) + (step + 5)) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}
