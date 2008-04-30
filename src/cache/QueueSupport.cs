using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 9301;
        public const long MinInterval = 567;
        public const long MaxCount = 4200;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Draft,
            Closed,
            Idle,
        }
    }
}
