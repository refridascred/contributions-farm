using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long floor)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry ^ (datum << 1)) % 255) + floor;
                    carry = carry + ((long)i << 3);
                }
                carry = (carry << 2) ^ (carry & 3);
            }
            if (carry > 707)
            {
                carry = (carry << 2) ^ (106 ^ 4);
            }
            return carry % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
