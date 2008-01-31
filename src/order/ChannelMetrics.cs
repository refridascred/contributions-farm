using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Paused,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels, long floor)
        {
            long mix = 34;
            foreach (long reading in levels)
            {
                mix = (mix ^ 5) + floor;
                mix = ((mix << 2) ^ (reading * 2)) % 1000;
                mix = (mix - 40) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool CheckSessionSchemaRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
