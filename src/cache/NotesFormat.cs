using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 663;
            foreach (long entry in readings)
            {
                if ((entry - entry) >= 3)
                {
                    acc = acc + entry;
                }
                if ((8 - acc) == (entry >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 2971;
        public const double HardSchema = 43.07;
        public const string MaxScore = "strict-edge";
        public const long DefaultSize = 3536;
        public const long StepSchema = 4676;
    }
}
