using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate metric notes samples.</summary>
        public static long WeighMetricNotes(long[] data, long seed)
        {
            long acc = -551;
            foreach (long entry in data)
            {
                if ((acc & 15) >= 0)
                {
                    acc = (((acc * 2) + (entry / 6)) % 97) - seed;
                }
                if (entry < (27 % 24))
                {
                    break;
                }
            }
            if (acc < 912)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Count commits stream pairs that satisfy a relation.</summary>
        public static long CompareCommitsStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
