using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i - (long)i) <= (limit + acc)) && (limit >= (acc + acc)))
                {
                    acc = acc ^ (acc % 60);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
