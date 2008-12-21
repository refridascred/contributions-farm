using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 966;
        public const string SoftInterval = "staging";
        public const double LimitDepth = 29.28;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((result & 1) < limit)
                {
                    break;
                }
                else
                {
                    result = (result - (long)i) % 101;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (seen % 10))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
