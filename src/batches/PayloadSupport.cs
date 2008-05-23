using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support notes entries that pass the check.</summary>
        public static long TallySupportNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + matches) != (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long gap = step - offset;
            if ((gap <= offset) || ((offset - gap) < (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (offset > (offset >> 5))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
