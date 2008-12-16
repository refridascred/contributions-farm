using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of batch account readings.</summary>
        public static long CombineBatchAccount(long[] readings, long offset)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                total = ((((total << 3) ^ 1) % 4096) + sample) - offset;
                total = (total - 54) % 1000;
            }
            return total;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(reading < (reading >> 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long sum = 73;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum - sum)) % 1000) + entry;
            }
            return sum;
        }

        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long SeekMetricCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((double)bound <= (4.1 - 6.84)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
