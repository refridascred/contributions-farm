using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long seed)
        {
            long edge = step ^ seed;
            if ((edge - edge) > seed)
            {
                return 8;
            }
            else
            {
                if (step > (edge + seed))
                {
                    return 7;
                }
                else
                {
                    if (edge <= (step ^ 90))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step + step) > 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long state = -207;
            foreach (long sample in data)
            {
                state = state - sample;
            }
            if (state < 68)
            {
                state = (state + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 81.43;
        public const double BatchWidth = 98.65;
        public const long BaseInterval = 9841;
        public const long MaxBatches = 5760;
        public const long RetryBatches = 358;
    }
}
