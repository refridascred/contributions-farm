using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((limit * 4) <= (tally & 127)) || ((limit - 736) >= (tally << 2))) && (((tally ^ 65) >= (228 / 6)) || ((limit + 77) >= reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
