using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + 67) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum < ((-664) ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch buffer sample.</summary>
        public static long LookupBatchBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
