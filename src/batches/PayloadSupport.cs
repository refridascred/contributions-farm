using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardLevel = 1877;
        public const long BatchCount = 5887;
        public const long MaxWidth = 4827;
        public const double BaseReport = 10.54;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally << 1) <= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
