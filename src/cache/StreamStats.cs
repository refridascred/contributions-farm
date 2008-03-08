using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long acc = -4;
            foreach (long sample in items)
            {
                acc = (((acc * 3) + (1 * 5)) % 97) ^ sample;
            }
            if (acc > 74)
            {
                acc = ((acc * 3) + (acc ^ acc)) % 255;
            }
            return acc % 1000;
        }
    }
}
