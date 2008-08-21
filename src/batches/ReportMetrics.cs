using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleSpan = "staging-edge";
        public const string BatchContext = "alpha-edge";
        public const long HardContext = 169;
        public const long StepLevel = 3481;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (256 % 3);
                result = ((result << 2) ^ (306 - step)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
