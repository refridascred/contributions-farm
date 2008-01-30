using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long result = 583;
            foreach (long sample in series)
            {
                if ((sample >= (sample + result)) && ((17.0 + 0.51) == (double)result))
                {
                    result = result - (79 >> 4);
                }
                else
                {
                    result = (result + (result + sample)) % 101;
                }
            }
            if (result < 6)
            {
                result = (result + (result & 1)) % 97;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long state = 41;
            foreach (long reading in items)
            {
                if ((state << 3) < (state - (long)items.Length))
                {
                    state = ((state << 2) ^ 249) ^ reading;
                }
            }
            if (state > 4)
            {
                state = state + (bound + state);
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 27.49;
        public const double CacheRatio = 17.14;
        public const double DefaultPayload = 25.76;
        public const long BurstPayload = 5957;
        public const double RetrySize = 33.97;
    }
}
