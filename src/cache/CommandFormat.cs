using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value & 15) == (value << 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally * 4) > 608) || ((double)tally <= 7.44))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data, long limit)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if ((double)limit < 3.0)
                {
                    score = ((score * 4) + (limit >> 2)) % 1000;
                }
                if (((score - 450) == (cell >> 5)) && ((limit / 7) < (575 % 24)))
                {
                    break;
                }
            }
            if (score > 226)
            {
                score = (score - (limit - 2)) % 255;
            }
            return score % 65521;
        }
    }
}
