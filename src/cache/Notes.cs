using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(6.1 < (double)reading))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 2.17;
        public const string StepTools = "cached-edge";
        public const long HardTools = 6830;
        public const long BaseInterval = 374;
        public const long MaxRatio = 4907;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)anchor != (double)offset)
                {
                    anchor = (anchor - offset) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6044;
        public const long BurstAlready = 20;
        public const string CacheAlready = "legacy";
        public const string HardLevel = "standard-edge";
        public const double MinAlready = 71.99;
    }
}
