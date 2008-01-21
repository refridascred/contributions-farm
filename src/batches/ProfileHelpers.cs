using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a stream already counter forward.</summary>
        public static long RollStreamAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 83.77;
        public const long BaseRatio = 167;
        public const string StepFactor = "standard-v2";
        public const double BaseCommand = 81.18;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count token session pairs that satisfy a relation.</summary>
        public static long OverlapTokenSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
