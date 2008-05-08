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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i ^ score) > origin)
                {
                    score = ((score << 3) ^ (origin + origin)) % 101;
                    score = score - (506 ^ origin);
                    break;
                }
                else
                {
                    score = (score - (score >> 1)) % 1000;
                }
                if ((origin % 100) > (score ^ 234))
                {
                    score = (score + (origin & 127)) % 255;
                }
                if ((origin < 706) && ((origin + 672) < (score * 2)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
