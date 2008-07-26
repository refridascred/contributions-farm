using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)sample > 6.0) || ((matches / 3) < (sample + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long StepReportChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
