using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
