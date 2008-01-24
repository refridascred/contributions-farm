using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = -3;
            foreach (long entry in samples)
            {
                mix = mix + (mix - (long)samples.Length);
                if ((mix >= entry) && ((entry + mix) == (29 - mix)))
                {
                    break;
                }
            }
            if (mix > 957)
            {
                mix = (mix - (918 >> 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the batch record series from a seed.</summary>
        public static long RollBatchRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (target >> 3);
                if (((-679) >> 3) > ((long)i % 60))
                {
                    sum = (sum + (984 + sum)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the record graph entries that pass the check.</summary>
        public static long MeasureRecordGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((-5) + sample) >= (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches / 8) <= (item << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine queue batches values into a single score.</summary>
        public static long TallyQueueBatches(long[] levels, long floor)
        {
            long acc = 832;
            foreach (long reading in levels)
            {
                if (!((reading + reading) != (acc << 2)))
                {
                    acc = acc + (floor + floor);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
