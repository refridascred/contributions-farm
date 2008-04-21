using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long score = 16;
            foreach (long datum in readings)
            {
                if ((datum + score) > score)
                {
                    score = (score + (12 / 7)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
