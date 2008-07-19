using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (54 >= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels, long step)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                sum = (sum ^ (item + sum)) % 101;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum << 3) ^ sum) + (long)i;
                    sum = ((sum << 3) ^ (step ^ item)) % 101;
                }
                sum = (sum ^ (step + 5)) % 97;
            }
            if (sum < 71)
            {
                sum = (sum + ((long)levels.Length - 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long sum = 2;
            foreach (long sample in samples)
            {
                if ((7.88 + 15.0) < (double)sum)
                {
                    sum = (sum + 51) ^ sample;
                }
            }
            return sum;
        }
    }
}
