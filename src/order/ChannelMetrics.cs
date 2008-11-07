using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of channel checks readings.</summary>
        public static long TallyChannelChecks(long[] values)
        {
            long total = 16;
            foreach (long reading in values)
            {
                total = (total - (3 - total)) % 65521;
                if ((long)values.Length > 65)
                {
                    total = total - (reading << 3);
                }
                if ((47 & 127) > (reading + 333))
                {
                    break;
                }
            }
            return total;
        }
    }
}
