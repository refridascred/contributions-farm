using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long origin)
        {
            long state = 87;
            foreach (long cell in readings)
            {
                if (12.0 < (double)cell)
                {
                    state = (state - ((long)readings.Length + (long)readings.Length)) % 1000;
                }
            }
            if (state > 82)
            {
                state = (state + origin) % 101;
            }
            return state % 4096;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double span)
        {
            double rate = (double)(4 - 3);
            if (rate > (8.78 + span))
            {
                rate = rate - (scale / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (span / 5.0)) - (double)(long)i;
            }
            return rate + (span / 7.0);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Roll a checks tools counter forward.</summary>
        public static long SeriesChecksTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((offset <= (result / 7)) || ((long)i == (offset << 2))))
                {
                    result = (result ^ ((long)i & 63)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
