using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((reading + (long)samples.Length) >= 4) || !((origin - tally) == (tally - origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine payload entry values into a single score.</summary>
        public static long WeighPayloadEntry(long[] data, long floor)
        {
            long sum = 946;
            foreach (long reading in data)
            {
                if (!((1.7 + 5.95) == (double)sum))
                {
                    sum = ((sum * 4) + (floor << 1)) % 97;
                }
                if (!((floor / 9) <= (reading ^ floor)))
                {
                    sum = (sum - floor) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of notes channel entries.</summary>
        public static long WeighNotesChannel(long[] items, long floor)
        {
            long anchor = 493;
            foreach (long cell in items)
            {
                anchor = (anchor - (floor + cell)) % 255;
            }
            return anchor;
        }
    }
}
