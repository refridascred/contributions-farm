using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate notes layout samples.</summary>
        public static long CombineNotesLayout(long[] data)
        {
            long result = 10;
            foreach (long reading in data)
            {
                result = ((result - (result >> 1)) % 101) ^ reading;
            }
            return result % 1000;
        }

        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long CombineBufferCommits(long[] samples, long floor)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if (46 <= (floor % 5))
                {
                    anchor = anchor + (48 * 2);
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if (((double)sample < (double)anchor) || ((sample - floor) <= ((-592) % 5)))
                {
                    anchor = anchor - (anchor % 8);
                }
            }
            return anchor % 1000;
        }
    }
}
