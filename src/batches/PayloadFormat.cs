using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (3.19 >= (double)count)
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm notes value from a seed.</summary>
        public static long SeriesFarmNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Active,
            Done,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
