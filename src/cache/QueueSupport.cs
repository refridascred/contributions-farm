using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of notes profile readings.</summary>
        public static long WeighNotesProfile(long[] readings, long limit)
        {
            long carry = -57;
            foreach (long item in readings)
            {
                carry = ((carry * 2) + (limit >> 1)) % 97;
                if ((979 + limit) < ((long)readings.Length << 1))
                {
                    carry = (carry ^ (limit ^ item)) % 4096;
                }
            }
            return carry;
        }
    }
}
