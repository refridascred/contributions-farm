using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Paused,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            if (((double)step >= (9.0 - 7.3)) && ((4.2 / 6.0) > (double)step))
            {
                return 6;
            }
            else
            {
                if (0 < (step >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((bound & 255) <= step) || (bound <= (bound << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 10) > (step << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
