using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Dropped,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of stats tools readings.</summary>
        public static long TotalStatsTools(long[] data, long limit)
        {
            long result = 8;
            foreach (long value in data)
            {
                if (((double)result < (double)71) || ((double)result != (6.4 + 15.0)))
                {
                    result = (result ^ (limit << 3)) ^ value;
                }
                else
                {
                    result = result - (31 & 3);
                }
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum <= (datum + hits)) || (datum > (hits - datum))) || !((double)datum == (11.0 - 5.2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
