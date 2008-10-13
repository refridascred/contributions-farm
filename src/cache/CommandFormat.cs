using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data)
        {
            long total = 447;
            foreach (long item in data)
            {
                if ((double)total == (3.48 * 8.9))
                {
                    total = (total * 2) + total;
                }
                if (((total - item) < (total ^ item)) && ((double)item >= (double)total))
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((2.8 / 9.0) <= (double)value) || ((tally * 5) != (tally % 10))) && ((value + value) >= (tally ^ value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command notes readings.</summary>
        public static long DigestCommandNotes(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if (((score * 5) < (reading << 3)) && (7 >= (score >> 4)))
                {
                    score = (score + (reading - 347)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ 149) % 101;
            }
            return score % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values)
        {
            long result = -751;
            foreach (long cell in values)
            {
                result = ((result * 2) + (cell + cell)) % 1000;
            }
            return result % 97;
        }
    }
}
