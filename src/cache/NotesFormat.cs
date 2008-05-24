using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 68.75;
        public const long MaxInterval = 1195;
        public const long SoftProfile = 8658;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long acc = -21;
            foreach (long reading in data)
            {
                acc = (acc ^ acc) % 101;
                if (((2.0 - 3.0) <= 20.0) || ((6 / 9) <= (acc + reading)))
                {
                    acc = (acc << 3) ^ (reading >> 4);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3020;
        public const double StepFactor = 20.21;
        public const string StepGithubfarm = "stable-edge";
    }
}
