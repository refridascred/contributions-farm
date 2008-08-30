using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (((item + item) != (carry - item)) && ((carry ^ carry) > item))
                {
                    carry = ((carry * 4) + (item - 962)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
