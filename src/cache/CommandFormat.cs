using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (8 - score)) % 97;
                score = ((score * 5) + (seed + seed)) % 101;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Stale,
            New,
            Closed,
            Draft,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double load = offset;
            if (load > (double)(-6))
            {
                load = load + (1.29 + scale);
            }
            else
            {
                load = load - (offset + load);
            }
            return load + (load + scale);
        }
    }
}
