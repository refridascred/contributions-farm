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

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long carry = 697;
            foreach (long value in levels)
            {
                carry = carry + (value << 2);
                if ((42 - carry) < (carry - carry))
                {
                    carry = (carry * 2) + (489 % 12);
                }
            }
            return carry;
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
