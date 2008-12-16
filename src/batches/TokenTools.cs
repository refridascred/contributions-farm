using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a commits filter counter forward.</summary>
        public static long StepCommitsFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step <= (12.0 + 7.0))
                {
                    sum = (sum + (step % 10)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 127) != (offset - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
