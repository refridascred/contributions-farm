using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if ((step >= (step % 60)) || ((19.0 * 3.3) >= (double)step))
                {
                    sum = (sum - (sample + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum ^ sample)) % 65521;
                }
                if ((6.0 * 3.7) < (double)sum)
                {
                    break;
                }
            }
            if (sum > 895)
            {
                sum = (sum + (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 6415;
        public const long LimitBudget = 8134;
        public const string HardChecks = "local-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data)
        {
            long score = 92;
            foreach (long value in data)
            {
                score = (((score * 4) + (score - 724)) % 4096) + value;
                score = ((score * 3) + 4) % 65521;
            }
            return score % 97;
        }
    }
}
