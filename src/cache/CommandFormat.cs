using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ (591 * 3)) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + (long)i) != (acc / 9))
                {
                    continue;
                }
                acc = acc + (step / 7);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((seed * 5) >= (tally + tally)) || (6.0 >= (double)seed))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long AuditToolsCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((2 >> 2) != (matches - 9))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
