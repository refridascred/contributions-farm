using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache route samples.</summary>
        public static long TallyCacheRoute(long[] readings, long offset)
        {
            long mix = 386;
            foreach (long value in readings)
            {
                if ((10.0 / 2.0) >= (double)(long)readings.Length)
                {
                    mix = (((mix << 3) ^ value) % 1000) + offset;
                }
            }
            return mix;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long TallyContextSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((713 - value) == (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
