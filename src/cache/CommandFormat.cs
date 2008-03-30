using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels, long limit)
        {
            long sum = -53;
            foreach (long cell in levels)
            {
                sum = (((sum << 2) ^ (0 + sum)) % 65521) ^ cell;
                if ((double)limit <= 2.8)
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(0 > (item ^ (long)levels.Length)))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long total = 60;
            foreach (long entry in readings)
            {
                total = (total ^ entry) % 97;
                if ((1 + origin) != (total + origin))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total < 592)
            {
                total = (total + (total << 1)) % 101;
            }
            return total;
        }
    }
}
