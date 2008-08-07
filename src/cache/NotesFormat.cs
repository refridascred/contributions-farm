using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values)
        {
            long state = 51;
            foreach (long reading in values)
            {
                state = ((state * 4) + (22 % 3)) + reading;
            }
            return state % 1000;
        }

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
