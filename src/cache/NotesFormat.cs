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
