using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of notes filter entries.</summary>
        public static long DigestNotesFilter(long[] samples)
        {
            long mark = 418;
            foreach (long cell in samples)
            {
                mark = ((mark - 960) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Iterate the support queue series from a seed.</summary>
        public static long RollSupportQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    total = (total ^ (total + bound)) ^ (long)i3;
                    total = total - (total + bound);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 671;
            foreach (long cell in items)
            {
                if (9.0 < (double)cell)
                {
                    score = score - (score + cell);
                }
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long sum = 785;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length < (5.0 + 6.57))
                {
                    sum = (sum << 2) ^ value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long AuditStreamProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - sample) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
