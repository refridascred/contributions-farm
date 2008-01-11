using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the notes window entries that pass the check.</summary>
        public static long AuditNotesWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(((5.7 - 7.8) != (double)reading) || ((double)seen <= (7.09 - 6.67))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Locked,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long target, long bound)
        {
            long step = target ^ bound;
            if ((step + bound) > (step + 1))
            {
                return 2;
            }
            else
            {
                if (!(step >= (target * 5)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1543;
        public const double StepChecks = 9.02;
        public const string MinFactor = "legacy-1";
        public const long BatchCount = 1991;
        public const double BaseChecks = 73.9;
    }
}
