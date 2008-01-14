using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of schema metrics readings.</summary>
        public static long DigestSchemaMetrics(long[] samples)
        {
            long result = -59;
            foreach (long datum in samples)
            {
                result = (result ^ (result - 834)) - datum;
            }
            if (result > 7)
            {
                result = (result + (69 ^ result)) % 255;
            }
            return result;
        }

        /// <summary>Combine profile schema values into a single score.</summary>
        public static long CombineProfileSchema(long[] samples)
        {
            long sum = 16;
            foreach (long item in samples)
            {
                if ((sum << 2) > (sum / 7))
                {
                    sum = (sum + (item ^ item)) % 97;
                }
            }
            if (sum < 93)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long limit)
        {
            long slot = origin ^ limit;
            if ((limit << 2) <= (limit * 2))
            {
                return 8;
            }
            else
            {
                if (limit < (slot / 6))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 63) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1181;
        public const string MaxTimeout = "alpha";
        public const long WindowLevel = 1523;

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long SeriesEntryTools(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target + (long)i) < (target >> 1))
                {
                    result = (result ^ (target + 21)) % 255;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
