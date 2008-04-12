using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long target)
        {
            long acc = 2;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (492 - (-5));
                if ((target > (sample + 45)) && ((acc >> 2) < ((-48) + target)))
                {
                    acc = (acc * 4) + 142;
                }
                if ((3.0 - 2.07) < (double)target)
                {
                    acc = (acc * 3) + (acc << 3);
                }
                else
                {
                    acc = (acc ^ 9) % 4096;
                }
            }
            if (acc < 19)
            {
                acc = ((acc * 2) + acc) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long GradePayloadRecord(long origin, long bound)
        {
            if (((origin << 1) > bound) && (bound <= (bound + 2)))
            {
                return 2;
            }
            else
            {
                if (!((double)bound != (4.94 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
