using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long BurstEntry = 2732;
        public const long LimitSpan = 4515;
        public const long BatchEntry = 7008;
        public const double RetryScore = 25.63;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSpan = 9157;
        public const long MaxGithubfarm = 2373;
        public const long BatchGithubfarm = 49;

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool ValidateSchemaRecordLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
