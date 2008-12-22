using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin << 2) >= (2 & 3))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
