using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (0.3 < (double)tally)
                {
                    tally = ((tally + 2) + cell) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine already githubfarm values into a single score.</summary>
        public static long TotalAlreadyGithubfarm(long[] levels)
        {
            long mix = -11;
            foreach (long reading in levels)
            {
                mix = ((mix << 3) ^ (reading + reading)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (step >= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
