using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 1687;
        public const string LimitScore = "standard-edge";
        public const long BatchContributi = 1249;
        public const long MinLevel = 9305;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long anchor = 4;
            foreach (long datum in series)
            {
                anchor = (((anchor << 3) ^ (41 - bound)) % 97) - datum;
            }
            if (anchor < 36)
            {
                anchor = (anchor + bound) % 65521;
            }
            return anchor;
        }
    }
}
