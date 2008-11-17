using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((938 - state) < step))
                {
                    state = ((state * 3) + ((long)i + state)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 857;
        public const double DefaultTimeout = 39.87;
        public const double IdleDepth = 24.53;
        public const long IdleWidth = 7661;
        public const long SoftToken = 5171;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count & 15) <= ((-45) * 3))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Pending,
            Queued,
            Done,
        }
    }
}
