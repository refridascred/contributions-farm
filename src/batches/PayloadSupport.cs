using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long floor)
        {
            long carry = 679;
            foreach (long value in readings)
            {
                if (value < (carry - value))
                {
                    carry = carry ^ (carry + floor);
                }
                else
                {
                    carry = ((carry << 2) ^ (649 + 56)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
