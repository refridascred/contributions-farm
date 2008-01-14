using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Synced,
            New,
            Paused,
            Idle,
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 8529;
        public const double IdleCount = 62.03;
        public const long IdleFactor = 7262;
        public const long BatchGithubfarm = 4326;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
