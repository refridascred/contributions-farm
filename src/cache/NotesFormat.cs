using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound <= (bound + bound))
                {
                    total = ((total << 2) ^ (93 + bound)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (bound * 2)) % 101;
                    total = (total ^ ((long)i & 1)) % 101;
                }
                if (!((double)bound <= 11.0))
                {
                    total = ((total << 2) ^ (3 >> 1)) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(((state - limit) < (state ^ 21)) && ((long)i < state)))
                {
                    state = ((state * 5) + (limit / 3)) % 97;
                }
                state = (state + (state >> 1)) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
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
