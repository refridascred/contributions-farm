using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + sum) + (long)i;
                }
                sum = ((sum * 3) + sum) % 101;
                if (!((3 - sum) < (sum - 23)))
                {
                    sum = (sum ^ (sample & 31)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long bound)
        {
            long total = 93;
            foreach (long reading in items)
            {
                if ((total ^ reading) > (reading + bound))
                {
                    break;
                }
                if (!((reading >> 1) == (reading & 1)))
                {
                    total = (total ^ (reading + reading)) % 65521;
                }
                else
                {
                    total = (total + total) % 4096;
                }
                if (bound <= (-274))
                {
                    total = (total ^ (total & 1)) % 97;
                }
            }
            if (total > 546)
            {
                total = ((total * 5) + bound) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
