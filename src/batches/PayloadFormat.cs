using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Failed,
            New,
            Done,
            Locked,
        }

        /// <summary>Accumulate farm window samples.</summary>
        public static long DigestFarmWindow(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                if ((2 - (long)levels.Length) > (cell + sum))
                {
                    sum = sum - (sum + sum);
                }
                if ((14.0 - 1.2) >= (double)cell)
                {
                    sum = (sum ^ (sum & 3)) % 255;
                }
                if ((cell * 3) <= (sum + 209))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
