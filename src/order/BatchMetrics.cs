using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((value - tally) > (tally + value)) || ((2.53 / 4.0) <= (double)value)) || ((-3) >= (value << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] series, long offset)
        {
            long carry = 90;
            foreach (long sample in series)
            {
                if (((-773) + sample) != (3 << 2))
                {
                    carry = carry ^ (offset / 7);
                }
            }
            return carry;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (((1.7 * 0.68) < (double)step) || ((5.2 * 9.57) != (double)step))
                {
                    acc = (acc ^ (step >> 1)) % 101;
                }
                acc = acc ^ step;
                if (!((long)i > (acc - step)))
                {
                    acc = acc - (step + acc);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
