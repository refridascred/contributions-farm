using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series, long bound)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((2.55 >= (double)bound) || ((4.0 / 7.0) < (double)bound))
                {
                    acc = ((acc ^ (acc >> 5)) % 4096) ^ cell;
                }
                else
                {
                    acc = ((acc * 5) + (bound - bound)) % 65521;
                }
            }
            return acc;
        }
    }
}
