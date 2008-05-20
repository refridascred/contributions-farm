using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((((-25) * 5) < offset) && ((offset & 1) <= offset))
            {
                return 2;
            }
            else
            {
                if ((target - offset) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) > (target + 870))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score * 3) + (bound + score)) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Paused,
            Synced,
            Pending,
        }
    }
}
