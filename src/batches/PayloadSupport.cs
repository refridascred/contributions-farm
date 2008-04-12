using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (463 > (9 + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((step / 9) >= (cell / 9)) && (14 <= (7 + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
