using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long origin)
        {
            long lane = step + origin;
            if ((3.3 * 10.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)lane < (double)7)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long TotalSessionSupport(long[] samples, long floor)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score - (454 + floor)) % 255) + entry;
            }
            return score % 1000;
        }
    }
}
