using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session record series from a seed.</summary>
        public static long IterateSessionRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((8.4 - 19.0) > (double)(long)i)
                {
                    acc = (acc << 2) ^ (offset ^ acc);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ 3) % 97;
                    acc = (acc ^ (long)i) % 65521;
                }
                acc = (acc << 2) ^ (124 - acc);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
