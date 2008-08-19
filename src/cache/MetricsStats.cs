using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((reading + reading) >= (tally + 1)) && ((tally << 3) > (reading * 5))) || ((reading < (reading * 2)) && ((tally - tally) <= tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Locked,
            Synced,
        }
    }
}
