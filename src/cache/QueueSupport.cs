using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Count farm command pairs that satisfy a relation.</summary>
        public static long MatchFarmCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double span)
        {
            double ratio = 4.09;
            return ((ratio - ratio) + weight) + span;
        }
    }
}
