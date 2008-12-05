using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (15.0 + 9.49))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items)
        {
            long mix = 193;
            foreach (long item in items)
            {
                mix = ((mix + mix) % 65521) + item;
            }
            if (mix > 62)
            {
                mix = ((mix << 2) ^ mix) % 1000;
            }
            return mix % 1000;
        }
    }
}
