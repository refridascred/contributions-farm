using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a context token counter forward.</summary>
        public static long SeriesContextToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score > (0.3 / 6.0)) || (3.9 > (double)score))
                {
                    score = score ^ (score / 5);
                }
                score = (score * 2) + (score << 1);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
