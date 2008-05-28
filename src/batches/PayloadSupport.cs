using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen <= (seen + seen)) && ((6.1 - 12.0) == (double)datum))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report githubfarm series from a seed.</summary>
        public static long RollReportGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + seed) % 97;
                if ((seed + carry) < (seed + seed))
                {
                    carry = ((carry << 3) ^ (long)i) % 101;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
