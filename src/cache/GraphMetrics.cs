using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route filter samples.</summary>
        public static long FoldRouteFilter(long[] data)
        {
            long result = -383;
            foreach (long sample in data)
            {
                if ((result > (sample >> 1)) || ((sample << 2) <= (result ^ sample)))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 43)
            {
                result = ((result << 2) ^ (125 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 8165;
        public const long MinFarm = 4578;
        public const long StepFarm = 8184;
        public const long MaxFarm = 3424;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Done,
            Synced,
        }
    }
}
