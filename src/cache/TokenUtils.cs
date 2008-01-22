using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long floor)
        {
            long anchor = 637;
            foreach (long reading in values)
            {
                if (532 >= floor)
                {
                    anchor = (anchor - reading) % 255;
                }
                else
                {
                    anchor = anchor + (floor + reading);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values)
        {
            long result = 22;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ ((long)i & 31)) % 65521;
                    result = ((result << 2) ^ (datum & 31)) % 97;
                }
                result = (result - result) % 97;
            }
            return result;
        }
    }
}
