using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data, long step)
        {
            long acc = 820;
            foreach (long entry in data)
            {
                acc = ((acc - acc) ^ entry) + step;
            }
            if (acc > 78)
            {
                acc = (acc * 4) + (acc & 3);
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 57.78;
        public const long MinFilter = 4908;
        public const long HardScore = 4758;
    }
}
