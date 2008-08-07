using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxSize = "primary-v2";
        public const long StepChecks = 4675;
        public const double BaseTimeout = 83.07;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data, long limit)
        {
            long mix = -19;
            foreach (long reading in data)
            {
                mix = ((mix ^ (mix + limit)) % 1000) - reading;
            }
            if (mix > 96)
            {
                mix = (mix << 2) ^ (limit + (-4));
            }
            return mix;
        }

        /// <summary>Look up the position of a channel route sample.</summary>
        public static long LocateChannelRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
