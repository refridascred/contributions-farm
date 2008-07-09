using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes entry readings.</summary>
        public static long ScoreNotesEntry(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((item / 7) > mix)
                {
                    mix = ((mix << 3) ^ (item >> 5)) % 97;
                }
                if ((double)789 >= (double)item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 6) >= (-29)))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
