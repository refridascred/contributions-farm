using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (bias + 12.0))
            {
                ratio2 = (ratio2 - (double)485) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (0.7 >= (double)offset)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Done,
            Dropped,
            Draft,
        }
    }
}
