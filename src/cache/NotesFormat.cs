using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many command format samples are out of range.</summary>
        public static long AuditCommandFormatGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)seed >= (double)31)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long floor)
        {
            long sum = 544;
            foreach (long sample in samples)
            {
                sum = (((sum << 3) ^ (floor % 8)) % 4096) + sample;
            }
            return sum % 1000;
        }

        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long AuditMetricsCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value > 20.0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
