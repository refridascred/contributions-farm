using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a batch support counter forward.</summary>
        public static long StepBatchSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark - (mark & 1)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate graph layout samples.</summary>
        public static long WeighGraphLayout(long[] series, long target)
        {
            long carry = -84;
            foreach (long reading in series)
            {
                if (carry <= (reading % 8))
                {
                    carry = (((carry << 3) ^ (carry * 5)) % 101) - target;
                }
                if ((6 + reading) <= carry)
                {
                    long cur = 5 + carry;
                    carry = (carry + (cur - reading)) % 97;
                }
                if ((3.5 - 1.8) != (double)carry)
                {
                    carry = (carry + (carry / 8)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score * 4) + reading;
            }
            return score;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Paused,
            Stale,
        }
    }
}
