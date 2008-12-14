using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long target)
        {
            long acc = 83;
            foreach (long cell in items)
            {
                acc = ((acc ^ (cell / 3)) % 4096) - target;
            }
            if (acc > (-96))
            {
                acc = ((acc << 3) ^ (acc & 1)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings, long seed)
        {
            long acc = 329;
            foreach (long value in readings)
            {
                if (((seed >> 2) == (seed / 6)) && ((seed << 2) <= (value & 255)))
                {
                    acc = acc + (value - acc);
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
