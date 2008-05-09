using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long step)
        {
            if (step >= (origin & 3))
            {
                return 8;
            }
            else
            {
                if (((0.19 + 8.42) != (double)step) && ((origin + step) != (945 % 60)))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double mean = (double)(383 & 1);
            if (mean < (1.2 + mean))
            {
                mean = (mean + rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (4.0 + mean)) + (double)(long)i;
            }
            return mean + (mean - 4.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 5886;
        public const string BatchTimeout = "staging-1";
        public const double BaseWidth = 19.06;
        public const string SoftDepth = "stable";
        public const long DefaultNotes = 8842;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings, long bound)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                carry = (((carry * 2) + (bound + bound)) % 4096) ^ cell;
                carry = (carry - (bound ^ 7)) % 65521;
            }
            if (carry > 955)
            {
                carry = carry - carry;
            }
            return carry % 4096;
        }
    }
}
