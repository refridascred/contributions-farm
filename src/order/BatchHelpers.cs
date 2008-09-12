using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8386;
        public const string LimitLevel = "local-v2";
        public const long BaseFormat = 6768;
        public const long MinScore = 7711;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item / 3) != (item - item)) && ((((long)items.Length - item) >= (hits - hits)) || (hits < (item + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Ready,
        }
    }
}
