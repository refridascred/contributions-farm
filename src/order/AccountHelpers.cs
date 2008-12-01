using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of farm entry readings.</summary>
        public static long CompareFarmEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Queued,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                if (!!((long)i >= ((long)i >> 5)))
                {
                    sum = (sum ^ (step - step)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long total = 37;
            foreach (long datum in items)
            {
                if ((double)datum < (double)447)
                {
                    total = ((total << 3) ^ total) % 255;
                    total = ((total * 4) + (total & 3)) % 255;
                }
                if ((total & 1) > (total + total))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total * 5) + datum;
                }
            }
            if (total < 34)
            {
                total = (total + (total * 2)) % 101;
            }
            return total;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Done,
            Locked,
            Idle,
        }
    }
}
