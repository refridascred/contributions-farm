using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long target2)
        {
            long lane = target + target2;
            if (!(target2 < (lane - lane)))
            {
                return 2;
            }
            else
            {
                if (target > (2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 30.66;
        public const long DefaultChannel = 9016;
        public const double RetryChannel = 9.52;
        public const double MinChannel = 54.2;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                mark = (mark ^ origin) - value;
            }
            return mark % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2332;
        public const string HardInterval = "primary-edge";
        public const long BatchSchema = 4009;

        /// <summary>Match up notes batches samples.</summary>
        public static long OverlapNotesBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
