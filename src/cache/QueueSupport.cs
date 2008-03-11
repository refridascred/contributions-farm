using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long origin)
        {
            if ((3.0 * 7.9) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((182 - origin) >= origin)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin != (15.0 + 5.33)) && ((double)origin != (5.53 * 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
