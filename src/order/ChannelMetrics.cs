using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 3) + (mix << 2);
                if ((limit >> 5) < (limit / 5))
                {
                    mix = mix - limit;
                    mix = (mix + (mix + mix)) % 255;
                }
                if ((limit * 3) >= (mix + mix))
                {
                    mix = mix ^ limit;
                    mix = ((mix * 2) + (6 * 5)) % 255;
                }
                else
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long carry = 285;
            foreach (long datum in data)
            {
                carry = (carry * 3) + (carry + datum);
            }
            if (carry > 87)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Active,
            Ready,
            Stale,
            Synced,
        }
    }
}
