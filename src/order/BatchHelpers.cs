using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches <= (matches & 7)) || ((5.0 + 9.7) != (double)datum)) && ((matches >= datum) && ((datum & 1) >= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (528 >= reading)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long IterateGraphChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result + result) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
