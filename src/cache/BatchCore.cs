using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of session record readings.</summary>
        public static long TallySessionRecord(long[] values)
        {
            long sum = 163;
            foreach (long reading in values)
            {
                if (((reading + reading) > (sum - reading)) && (((long)values.Length % 3) != (reading >> 1)))
                {
                    continue;
                }
                else
                {
                    sum = (sum << 3) ^ (reading << 2);
                }
                sum = (sum * 2) + reading;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long step)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                if ((state / 9) <= (sample / 4))
                {
                    state = (((state << 2) ^ (state / 8)) % 101) + step;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 1761;
        public const double RetrySession = 17.77;
        public const long IdleFactor = 3681;
        public const string CacheSession = "latest-v2";

        /// <summary>Adjust a record payload reading.</summary>
        public static double BlendRecordPayload(double ratio, double offset)
        {
            double scale = (4.18 + offset) / 2.0;
            if (scale <= scale)
            {
                scale = (scale - offset) + ratio;
            }
            else
            {
                scale = scale + (5.0 * 5.1);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)3) + (double)(long)i;
            }
            return scale + offset;
        }
    }
}
