using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the payload buffer series from a seed.</summary>
        public static long StepPayloadBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (mark >> 4)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((origin << 2) <= (hits * 3))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 4) > (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster buffer readings against a rule.</summary>
        public static long CountClusterBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((7 * 5) < (cell * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
