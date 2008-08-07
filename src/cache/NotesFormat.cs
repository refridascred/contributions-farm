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

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor - (long)i) == (target + (long)i))
                {
                    anchor = ((anchor * 3) + (target / 7)) % 255;
                    anchor = ((anchor << 2) ^ ((long)i % 12)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor * 5)) % 65521;
                    anchor = ((anchor << 2) ^ (target + anchor)) % 1000;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    anchor = (anchor ^ (3 << 1)) ^ (long)i3;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
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
