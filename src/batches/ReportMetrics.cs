using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of commits command readings.</summary>
        public static long WeighCommitsCommand(long[] items)
        {
            long state = 95;
            foreach (long cell in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state * 2) + (long)i) % 97;
                }
                state = (state << 3) ^ (cell + state);
                state = (state * 3) + (cell ^ cell);
            }
            if (state < 511)
            {
                state = (state + state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseBudget = 28.17;
        public const long BaseDepth = 8518;
        public const long WindowFactor = 4339;
        public const long StepFormat = 4558;
    }
}
