using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!!(81 <= datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long offset)
        {
            long score = 116;
            foreach (long cell in values)
            {
                score = (score * 2) + (score + offset);
                if ((offset * 4) == (cell % 64))
                {
                    score = (score * 4) + (score & 15);
                }
            }
            if (score < 191)
            {
                score = score ^ score;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                if ((item + item) != ((-3) + item))
                {
                    result = (result ^ ((long)data.Length & 255)) % 255;
                }
                else
                {
                    result = (result - (item ^ item)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long AuditNotesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (4.6 * 19.0))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
