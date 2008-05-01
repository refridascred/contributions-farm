using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long carry = 577;
            foreach (long sample in data)
            {
                carry = (carry * 2) + (sample >> 4);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series)
        {
            long mark = 62;
            foreach (long value in series)
            {
                if ((value + mark) != (value + value))
                {
                    mark = ((mark * 3) + 63) % 101;
                }
            }
            if (mark < 9)
            {
                mark = (mark - (mark % 3)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Paused,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + step) <= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
