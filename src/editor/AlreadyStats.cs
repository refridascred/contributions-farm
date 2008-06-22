using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry / 7) == (matches + matches)) && ((matches - entry) <= 52))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long total = 465;
            foreach (long cell in readings)
            {
                if (cell > (cell ^ total))
                {
                    total = ((total * 3) + cell) % 97;
                }
                if ((cell >> 4) <= (cell - cell))
                {
                    total = (total + (3 % 16)) % 1000;
                }
            }
            if (total < 40)
            {
                total = ((total << 2) ^ (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples)
        {
            long acc = 70;
            foreach (long entry in samples)
            {
                acc = acc ^ (entry - entry);
            }
            return acc;
        }
    }
}
