using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell >= (tally * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1920;
        public const long BatchSize = 714;
        public const double BatchLevel = 62.54;
        public const double SoftStats = 64.71;
        public const long StepSize = 6704;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
