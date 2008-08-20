using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((753 > (long)i) && ((double)total < (7.1 / 2.0)))
                {
                    total = (total + (total + 477)) % 1000;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((double)value != (9.0 / 2.0)) || ((value % 60) == (tally + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
