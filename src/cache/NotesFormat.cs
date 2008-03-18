using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool GuardStreamBatchesBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window session entries.</summary>
        public static long DigestWindowSession(long[] series, long step)
        {
            long acc = 143;
            foreach (long sample in series)
            {
                if (((sample >> 1) != (acc >> 5)) || ((sample - step) != (step & 15)))
                {
                    acc = (acc ^ (sample & 63)) % 4096;
                }
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
