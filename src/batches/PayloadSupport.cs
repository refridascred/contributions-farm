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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value & 3) != (value + 380))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
