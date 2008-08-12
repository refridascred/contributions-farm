using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of support context entries.</summary>
        public static long TallySupportContext(long[] items, long target)
        {
            long score = -9;
            foreach (long value in items)
            {
                score = ((((score << 3) ^ 716) % 1000) - value) + target;
            }
            if (score > 153)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long origin)
        {
            long next = target + origin;
            if (target < (target << 2))
            {
                return 5;
            }
            else
            {
                if (((target / 3) > (85 + (-286))) || (607 > (next - (-95))))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Adjust a checks entry reading.</summary>
        public static double AdjustChecksEntry(double bias, double offset)
        {
            double load = (double)(5 >> 3);
            if (load > (bias / 2.0))
            {
                load = (load - load) + offset;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (load - bias);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (1.7 * 1.13))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
