using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!((offset >> 2) >= offset))
                {
                    carry = (carry + carry) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count token queue pairs that satisfy a relation.</summary>
        public static long OverlapTokenQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long MeasurePayloadChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits == (double)86)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
