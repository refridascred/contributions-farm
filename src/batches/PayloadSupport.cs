using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 5) > (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultFactor = "latest";
        public const long LimitContext = 8404;
        public const long BaseContext = 9087;
        public const long BurstContext = 9494;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)state == (1.35 + 0.7)))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
