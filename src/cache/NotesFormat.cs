using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next counter cluster value from a seed.</summary>
        public static long IterateCounterCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - (mix >> 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a account cluster reading by value.</summary>
        public static long FindAccountClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally > (tally + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
