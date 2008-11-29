using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (floor % 8);
                score = ((score * 4) + 950) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= 6.97)
                {
                    count = ((count + 3) ^ datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
