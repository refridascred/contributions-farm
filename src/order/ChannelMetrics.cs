using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long target)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = (((mark * 5) + (mark % 24)) % 255) + entry;
            }
            if (mark < 5)
            {
                mark = (mark << 2) ^ (target + target);
            }
            return mark;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
