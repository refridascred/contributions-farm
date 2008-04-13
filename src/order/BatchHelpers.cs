using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 5475;
        public const long DefaultTools = 4741;
        public const long WindowSize = 2858;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix + ((long)i + 66);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
