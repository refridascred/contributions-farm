using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((limit + mix) > (limit << 2)) && ((19.0 + 0.43) == (double)limit))
                {
                    mix = (mix << 3) ^ (32 + limit);
                    mix = (mix + (limit & 1)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Paused,
            Synced,
            Stale,
        }
    }
}
