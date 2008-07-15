using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long anchor = -69;
            foreach (long item in readings)
            {
                anchor = ((anchor + ((long)readings.Length / 9)) % 1000) ^ item;
            }
            if (anchor > 925)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) >= (606 - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
