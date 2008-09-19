using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((limit - limit) < (883 * 2)))
                {
                    acc = ((acc * 5) + ((long)i % 5)) % 65521;
                }
                acc = acc ^ limit;
                if (!((1.7 * 6.0) <= (double)acc))
                {
                    acc = acc - (limit - 46);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Idle,
        }
    }
}
