using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine token cluster values into a single score.</summary>
        public static long FoldTokenCluster(long[] items)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (sample & 3)) % 1000;
                if ((sample <= (571 + carry)) && (1 < carry))
                {
                    carry = carry + (sample % 10);
                }
            }
            return carry % 4096;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                }
                if ((686 > bound) || (bound <= score))
                {
                    score = score ^ (bound ^ 8);
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (long)i) % 101;
                }
                score = (score << 2) ^ (bound & 255);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values)
        {
            long anchor = 5;
            foreach (long cell in values)
            {
                if ((cell - 475) == (anchor ^ cell))
                {
                    anchor = (anchor - cell) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor - (long)values.Length);
                }
            }
            if (anchor > 91)
            {
                anchor = anchor - 105;
            }
            return anchor;
        }
    }
}
