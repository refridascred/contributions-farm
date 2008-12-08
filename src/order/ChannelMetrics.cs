using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long step)
        {
            long mix = 331;
            foreach (long cell in data)
            {
                mix = (mix - (cell ^ mix)) - step;
            }
            if (mix < 2)
            {
                mix = (mix ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
