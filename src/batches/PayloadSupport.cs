using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Accumulate context metric samples.</summary>
        public static long ScoreContextMetric(long[] values)
        {
            long score = 14;
            foreach (long value in values)
            {
                score = (score + (value << 1)) % 65521;
                if (((value + value) != (score / 5)) || (score < (value + 278)))
                {
                    score = ((score * 4) + (9 + score)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long floor)
        {
            if (((bound + bound) != (bound + (-708))) || ((floor >> 4) >= (floor + bound)))
            {
                return 0;
            }
            else
            {
                if (!((floor - bound) > (bound << 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
