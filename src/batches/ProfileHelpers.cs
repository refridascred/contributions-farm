using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7771;
        public const double BurstFactor = 60.27;
        public const long IdleWidth = 9116;

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double bias, double floor)
        {
            double load = 10.0;
            if (load >= (4.7 + load))
            {
                load = load - (7.8 - load);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + load)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long origin)
        {
            long sum = 339;
            foreach (long item in values)
            {
                if ((item <= (origin - origin)) || ((9 % 24) > sum))
                {
                    sum = (sum ^ (6 ^ sum)) % 255;
                }
                if (item <= (3 - 632))
                {
                    sum = (sum - (item & 31)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + (item ^ sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1712;
        public const long MaxBatches = 8400;
        public const double IdleFactor = 9.94;

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long CountAlreadyCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 100) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
