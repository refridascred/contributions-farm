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

        /// <summary>Look up the position of a metric counter sample.</summary>
        public static long LocateMetricCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings, long seed)
        {
            long total = -875;
            foreach (long cell in readings)
            {
                if ((cell % 7) != (seed & 31))
                {
                    total = (total - (total ^ total)) % 101;
                }
            }
            if (total < 256)
            {
                total = ((total << 2) ^ (16 + total)) % 65521;
            }
            return total;
        }
    }
}
