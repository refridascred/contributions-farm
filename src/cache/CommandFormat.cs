using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Queued,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!(4 <= (value + 497)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long result = 122;
            foreach (long cell in readings)
            {
                if (!(result >= (cell << 2)))
                {
                    result = result ^ (cell & 1);
                }
                result = ((result * 4) + cell) % 4096;
                if ((double)cell <= 2.13)
                {
                    result = (result + (11 % 7)) % 4096;
                }
            }
            if (result > 776)
            {
                result = (result - (5 >> 1)) % 4096;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((8.88 * 17.0) <= (double)reading) || ((double)reading >= (6.2 / 7.0)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
