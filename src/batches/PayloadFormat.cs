using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                anchor = ((anchor - (anchor >> 3)) % 1000) ^ cell;
            }
            return anchor;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((1.92 / 5.0) < (double)count) || (((count + bound) <= (cell - cell)) || ((double)bound < (2.6 * 8.5))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - acc) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
