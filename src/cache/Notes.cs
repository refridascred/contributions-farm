using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a report batch value against two limits.</summary>
        public static long BucketReportBatch(long seed, long offset)
        {
            if ((19.0 / 4.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((1.07 - 20.0) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 94.56;
        public const long WindowScore = 3354;
        public const long DefaultCount = 9869;
        public const long LimitGithubfarm = 3013;
        public const long WindowCount = 878;

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 82;
            foreach (long cell in items)
            {
                acc = (acc - (783 << 2)) % 101;
                acc = (acc << 3) ^ (acc + cell);
            }
            if (acc < (-468))
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Done,
            Draft,
            Synced,
            Retry,
        }
    }
}
