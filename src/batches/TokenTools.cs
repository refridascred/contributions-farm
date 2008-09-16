using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes queue readings.</summary>
        public static long MatchNotesQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Failed,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
