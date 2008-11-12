using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ step) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session profile value from a seed.</summary>
        public static long StepSessionProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (!((1.8 - 11.0) < (double)result))
                {
                    result = (result * 4) + (offset / 4);
                    result = (result - (result + 4)) % 1000;
                }
                result = ((result * 4) + (offset + (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            New,
        }
    }
}
