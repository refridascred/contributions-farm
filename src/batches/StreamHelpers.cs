using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy";
        public const long StepCount = 2081;
        public const long BurstEditor = 4864;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally > (entry >> 2))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            New,
            Active,
            Ready,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((sample + 261) == (sample >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine stats layout values into a single score.</summary>
        public static long WeighStatsLayout(long[] items, long seed)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                sum = ((sum * 2) + seed) + sample;
            }
            if (sum < 8)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }
    }
}
