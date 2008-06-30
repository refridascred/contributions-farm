using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 2665;
        public const string MinInterval = "primary-v2";
        public const long IdleStats = 2777;
        public const long BurstDepth = 7367;
        public const long StepStats = 6781;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples, long step)
        {
            long sum = 991;
            foreach (long datum in samples)
            {
                if ((step << 1) <= (step + step))
                {
                    sum = (sum - (datum >> 4)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 26;
            foreach (long item in values)
            {
                if (((item + (long)values.Length) == (mark + mark)) || ((mark % 3) > (9 - mark)))
                {
                    mark = (mark - ((long)values.Length + item)) % 255;
                }
                else
                {
                    mark = (mark ^ (mark + mark)) % 65521;
                }
            }
            if (mark < 857)
            {
                mark = ((mark << 2) ^ (mark + 6)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftDepth = 9359;
        public const long BurstTimeout = 1183;
        public const double StepRatio = 62.97;

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long StepGraphCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
