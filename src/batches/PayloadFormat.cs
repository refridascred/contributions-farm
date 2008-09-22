using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) < bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long state = 261;
            foreach (long item in data)
            {
                if ((state - item) < (state & 7))
                {
                    state = ((state * 3) + (state << 3)) % 1000;
                }
            }
            if (state > 122)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (((5.7 + 3.27) > (double)item) && ((item / 6) <= (56 - total)))
                {
                    total = (total ^ (2 - total)) % 4096;
                }
            }
            if (total < 485)
            {
                total = total ^ (total % 7);
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4104;
        public const long MaxFactor = 8958;
        public const string BatchWidth = "legacy";
    }
}
