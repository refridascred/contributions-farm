using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + 761) < (count + 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if (!((3 & 3) > (state * 3)))
                {
                    state = (state + (entry & 127)) % 97;
                }
            }
            if (state > 7)
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
