using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long origin)
        {
            long step = target - origin;
            if ((6.01 * 2.43) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((7 % 16) >= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)target != (8.9 + 3.9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > (5 + 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long floor)
        {
            long acc = 34;
            foreach (long sample in samples)
            {
                if ((double)sample <= 1.3)
                {
                    acc = ((acc << 3) ^ floor) % 65521;
                }
                if (((acc ^ sample) < (acc * 4)) && ((double)sample >= (double)acc))
                {
                    acc = (acc + (acc - sample)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
