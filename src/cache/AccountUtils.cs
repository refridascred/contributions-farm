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

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels, long target)
        {
            long sum = 44;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ (sample >> 1)) % 255;
                if (sample >= (sample - target))
                {
                    break;
                }
            }
            return sum;
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
