using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (5.3 >= (double)floor)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 1) <= (hits % 10))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = ((total + (offset + offset)) % 97) + reading;
            }
            return total % 1000;
        }
    }
}
