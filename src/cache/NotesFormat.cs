using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a graph buffer counter forward.</summary>
        public static long DeriveGraphBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ result) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long MeasureCounterClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((3 - cell) > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
