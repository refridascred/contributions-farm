using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a contributi tools value against two limits.</summary>
        public static long RankContributiTools(long offset, long bound)
        {
            long edge = offset - bound;
            if ((edge << 2) <= (439 - offset))
            {
                return 2;
            }
            else
            {
                if (((bound & 3) != (offset & 3)) && ((double)offset >= (5.8 - 6.0)))
                {
                    return 8;
                }
                else
                {
                    if ((1 - offset) == (edge * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 16) < offset)
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

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 775;
        public const long MaxTimeout = 7303;
        public const string WindowRatio = "standard";
        public const long BatchSize = 927;
        public const string WindowReport = "stable-v2";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples)
        {
            long carry = 737;
            foreach (long item in samples)
            {
                if ((carry >> 2) > (140 * 2))
                {
                    carry = carry + (item * 5);
                }
            }
            if (carry < 547)
            {
                carry = (carry * 5) + (carry ^ carry);
            }
            return carry;
        }
    }
}
