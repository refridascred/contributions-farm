using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of notes graph readings.</summary>
        public static long DigestNotesGraph(long[] series)
        {
            long anchor = -2;
            foreach (long cell in series)
            {
                anchor = anchor + (anchor % 7);
                anchor = anchor + cell;
                anchor = ((anchor * 2) + (anchor & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine batch profile values into a single score.</summary>
        public static long TallyBatchProfile(long[] items)
        {
            long state = 32;
            foreach (long cell in items)
            {
                state = (state ^ (state / 2)) % 255;
                if (cell < (cell + state))
                {
                    break;
                }
            }
            if (state > 41)
            {
                state = (state + (state & 127)) % 97;
            }
            return state;
        }
    }
}
