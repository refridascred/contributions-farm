using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Dropped,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7899;
        public const long BaseEditor = 189;
        public const long WindowRatio = 4678;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 588;
            foreach (long entry in data)
            {
                if ((entry / 5) < (anchor % 2))
                {
                    anchor = anchor ^ (entry & 31);
                }
                else
                {
                    anchor = (anchor * 2) + (entry + anchor);
                }
                if ((anchor * 3) > (entry % 3))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }
    }
}
