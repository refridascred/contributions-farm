using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 3) + (score + 2);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - entry) >= (matches % 2))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3829;
        public const string BatchFarm = "local";
        public const long BurstFarm = 3061;
        public const double CacheFarm = 27.17;
        public const long StepFarm = 5524;
    }
}
