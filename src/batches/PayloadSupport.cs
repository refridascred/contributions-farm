using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                if ((13.0 + 3.0) > (double)score)
                {
                    score = ((score * 4) + (cell - score)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score % 60)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 73.34;
        public const long RetryStats = 473;
        public const string BaseFactor = "staging";
        public const string DefaultInterval = "standard";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (7.8 * 3.0))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
