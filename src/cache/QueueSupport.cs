using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
