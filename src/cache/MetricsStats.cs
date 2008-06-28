using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long carry = 84;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ (carry % 12)) % 65521;
                if (item >= (7 / 2))
                {
                    carry = (carry ^ (item << 2)) % 97;
                }
                else
                {
                    carry = carry ^ 5;
                }
            }
            if (carry > 9)
            {
                carry = (carry * 4) + (carry >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item << 3) != ((-3) / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue graph readings.</summary>
        public static long OverlapQueueGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
