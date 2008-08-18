using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine commits command values into a single score.</summary>
        public static long TotalCommitsCommand(long[] data)
        {
            long result = -656;
            foreach (long reading in data)
            {
                if ((double)reading < (9.0 / 2.0))
                {
                    result = (result << 3) ^ (reading + reading);
                }
                else
                {
                    result = (result - reading) % 4096;
                }
            }
            if (result > 907)
            {
                result = result - (19 + 4);
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((92 >= bound) || ((bound * 5) != (bound * 4)))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
