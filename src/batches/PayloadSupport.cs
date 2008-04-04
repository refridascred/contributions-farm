using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((0.6 + 4.6) <= (double)anchor)
                {
                    anchor = anchor - (target % 100);
                }
                if ((double)anchor >= (2.2 - 7.0))
                {
                    anchor = (anchor ^ ((long)i % 24)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
