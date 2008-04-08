using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values, long step)
        {
            long state = 37;
            foreach (long sample in values)
            {
                if (!((state - state) >= (sample + sample)))
                {
                    state = state - (step * 2);
                }
                else
                {
                    state = (state - step) % 255;
                }
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
