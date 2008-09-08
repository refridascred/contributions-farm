using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long MeasureAccountWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((8.0 * 1.4) < (double)sample) && ((1.03 - 3.0) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)target < (19.0 * 2.8))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items, long floor)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                if ((double)mix <= 0.9)
                {
                    mix = mix + (floor & 31);
                }
                if ((reading > (reading << 2)) && (reading > (mix - reading)))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 3) ^ (63 ^ mix)) % 97;
            }
            return mix;
        }
    }
}
