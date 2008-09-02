using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Done,
            New,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
