using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long target)
        {
            long result = 79;
            foreach (long entry in data)
            {
                result = (((result << 3) ^ (target + target)) % 1000) ^ entry;
            }
            return result;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double load = scale / 3.0;
            if (load > scale)
            {
                load = (load + load) - offset;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (double)276;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2522;
        public const long SoftMetrics = 1736;
        public const long IdleMetrics = 6662;
        public const long HardSpan = 6002;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long target)
        {
            long gap = offset + target;
            if (!((1.29 * 8.12) != (double)target))
            {
                return 0;
            }
            else
            {
                if ((target > (6 >> 1)) || ((gap * 4) < 0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
