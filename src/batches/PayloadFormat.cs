using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultLevel = 42.92;
        public const long StepCache = 7838;
        public const long BatchCache = 9946;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Failed,
            New,
            Done,
            Locked,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen >> 3) == (seen + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long step)
        {
            long prev = offset + step;
            if (step < prev)
            {
                return 2;
            }
            else
            {
                if ((step >= offset) || ((12.0 - 5.9) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (offset < (prev ^ prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
