using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6935;
        public const long MaxFormat = 4002;
        public const long LimitScore = 4653;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long carry = 90;
            foreach (long value in levels)
            {
                if ((78 - value) < (step << 1))
                {
                    carry = carry - (step >> 4);
                }
            }
            if (carry > 691)
            {
                carry = ((carry * 4) + carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((floor + floor) < ((-95) + 66))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
