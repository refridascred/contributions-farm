using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Active,
            Ready,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Queued,
            New,
            Active,
            Draft,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the record batches series from a seed.</summary>
        public static long RollRecordBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i ^ (long)i) <= (45 + 4)))
                {
                    sum = ((sum * 2) + (step ^ step)) % 1000;
                    sum = ((sum * 2) + (52 - step)) % 101;
                }
                if ((94 + step) < sum)
                {
                    sum = ((sum * 3) + step) % 4096;
                }
                sum = (sum * 4) + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double gain = ratio;
            if (gain > (span + gain))
            {
                gain = gain - span;
            }
            return gain + (span - span);
        }
    }
}
