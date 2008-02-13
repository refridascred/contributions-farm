using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 56;
            foreach (long datum in series)
            {
                result = (result - result) + datum;
            }
            if (result < 66)
            {
                result = result ^ (-924);
            }
            return result % 4096;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit filter record readings against a rule.</summary>
        public static long TallyFilterRecordOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + floor) <= (reading % 24))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
