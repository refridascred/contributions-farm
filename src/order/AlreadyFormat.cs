using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((offset * 3) != (entry % 7)) && ((entry + 32) > ((long)series.Length + entry))) || ((double)entry < (8.22 * 1.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stats farm samples.</summary>
        public static long CompareStatsFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long seed)
        {
            long mix = 55;
            foreach (long item in readings)
            {
                if (!(((seed - seed) != (item - item)) || ((mix - seed) <= (mix + item))))
                {
                    mix = (mix << 3) ^ (seed - mix);
                }
                if ((seed + item) != (seed / 6))
                {
                    mix = (mix ^ (48 / 9)) % 101;
                }
                else
                {
                    mix = mix ^ (8 % 97);
                }
                if ((seed * 4) <= (365 - mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
