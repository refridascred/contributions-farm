using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardBudget = 76.11;
        public const long StepFactor = 9784;
        public const string IdleSpan = "standard-v2";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value & 15) >= (683 - value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
