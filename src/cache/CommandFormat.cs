using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up commits batches samples.</summary>
        public static long OverlapCommitsBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples)
        {
            long acc = -274;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc << 3) ^ (acc << 1)) % 97) + (long)i;
                }
                if (5 >= entry)
                {
                    acc = (acc ^ ((long)samples.Length - acc)) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > (-449))
            {
                acc = ((acc * 2) + acc) % 255;
            }
            return acc;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Check that every cache command entry stays within the limit.</summary>
        public static bool GuardCacheCommandRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
