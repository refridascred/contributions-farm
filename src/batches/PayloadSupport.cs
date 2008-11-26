using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long TallyBatchGithubfarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + seen) <= (seen * 4))
                {
                    seen = ((seen + 2) - value) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
