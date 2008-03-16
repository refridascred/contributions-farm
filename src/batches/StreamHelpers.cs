using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels)
        {
            long result = 46;
            foreach (long entry in levels)
            {
                if (!((6.5 - 5.0) <= (double)result))
                {
                    result = (((result << 2) ^ result) % 1000) + entry;
                }
            }
            if (result < 72)
            {
                result = result - (result - result);
            }
            return result % 65521;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double weight = (double)96;
            if (weight > weight)
            {
                weight = ((weight - weight) - rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 19.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)acc < (double)floor) && ((floor - (long)i) >= 4))
                {
                    acc = ((acc * 5) + acc) % 255;
                    acc = (acc ^ (86 + 17)) % 4096;
                }
                acc = ((acc * 5) + ((long)i ^ (long)i)) % 101;
                if (floor < (6 % 3))
                {
                    acc = (acc ^ (acc >> 5)) % 1000;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = weight;
            return gain - (gain - floor);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((480 - offset2) > (offset2 + 6))
            {
                return 0;
            }
            else
            {
                if ((offset2 / 6) < (limit % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long CombineEditorMetric(long[] items)
        {
            long total = 79;
            foreach (long sample in items)
            {
                if ((sample ^ sample) < (total << 2))
                {
                    total = total ^ sample;
                }
            }
            return total;
        }
    }
}
