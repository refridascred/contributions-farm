using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 57.78;
        public const long MinFilter = 4908;
        public const long HardScore = 4758;
    }
}
