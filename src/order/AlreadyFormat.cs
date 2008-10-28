using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up already commits samples.</summary>
        public static long PairAlreadyCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double gain2 = bias + (bias * 3.5);
            if (gain2 >= (double)43)
            {
                gain2 = (gain2 - bias) - gain;
            }
            else
            {
                gain2 = gain2 - (gain2 - 1.1);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (double)19) + (double)(long)i;
            }
            return gain2 - (bias - 16.0);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Stale,
            Pending,
            Active,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Paused,
            Active,
        }
    }
}
