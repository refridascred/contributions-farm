using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepInterval = 65.61;
        public const long WindowCommits = 4082;
        public const long DefaultScore = 4733;
        public const long LimitCommits = 9168;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long floor)
        {
            long anchor = -200;
            foreach (long sample in series)
            {
                long prev = (floor / 9) << 3;
                anchor = ((anchor * 4) + (431 - prev)) % 97;
                if (((4.2 - 6.0) < (double)floor) && ((double)sample == (7.5 + 6.0)))
                {
                    anchor = (anchor ^ (floor / 8)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
