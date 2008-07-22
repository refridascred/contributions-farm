using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long mark = 39;
            foreach (long entry in data)
            {
                mark = mark - entry;
            }
            if (mark > 5)
            {
                mark = mark - (mark / 5);
            }
            return mark % 97;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double rate = 0.5;
            return ((rate + 5.2) + weight) + span;
        }

        /// <summary>Classify a contributi batches pair into a bucket.</summary>
        public static long GradeContributiBatches(long offset, long offset2)
        {
            if (offset >= offset2)
            {
                return 7;
            }
            else
            {
                if ((offset2 * 3) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
