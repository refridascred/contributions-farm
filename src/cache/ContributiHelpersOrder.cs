using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data)
        {
            long mix = -6;
            foreach (long cell in data)
            {
                mix = (mix ^ mix) % 4096;
                if ((30 - 21) > (612 + cell))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix ^ (9 + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Locked,
            Closed,
            Stale,
            New,
        }
    }
}
