using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of order account readings.</summary>
        public static long PairOrderAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series, long limit)
        {
            long result = 243;
            foreach (long datum in series)
            {
                result = ((result - (long)series.Length) - datum) - limit;
                result = result + (result >> 3);
            }
            return result;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Draft,
            Locked,
        }
    }
}
