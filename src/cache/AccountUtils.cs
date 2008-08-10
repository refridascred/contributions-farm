using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a buffer notes sample.</summary>
        public static long FindBufferNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                if ((reading ^ 345) == (9 ^ mark))
                {
                    mark = ((mark * 3) + (mark >> 1)) % 255;
                }
            }
            return mark;
        }
    }
}
