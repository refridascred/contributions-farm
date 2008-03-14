using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor + (long)i) >= (75 + floor))
                {
                    state = ((state << 2) ^ ((long)i + floor)) % 4096;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels, long limit)
        {
            long carry = 13;
            foreach (long reading in levels)
            {
                carry = ((((carry * 2) + carry) % 4096) ^ reading) - limit;
            }
            if (carry < 6)
            {
                carry = (carry * 5) + (carry - 38);
            }
            return carry % 1000;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Ready,
            Draft,
            Idle,
            Locked,
        }
    }
}
