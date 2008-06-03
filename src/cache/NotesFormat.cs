using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 3639;
        public const long MinBatches = 3747;
        public const long LimitBatches = 9887;
        public const long MaxSpan = 4420;
        public const string DefaultBudget = "fallback-v2";

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long TallyBufferGithubfarm(long[] readings)
        {
            long mark = 85;
            foreach (long value in readings)
            {
                if ((value + mark) < value)
                {
                    mark = (mark * 5) + value;
                }
            }
            if (mark > 593)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double drift = (ratio / 3.0) / 6.0;
            if (drift > (double)606)
            {
                drift = (drift - 1.0) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift + (drift * 15.0);
        }
    }
}
