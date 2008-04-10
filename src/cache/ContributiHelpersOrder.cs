using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSize = 96.1;
        public const string MaxReport = "alpha-edge";
        public const long DefaultTimeout = 1315;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 2) + (long)i;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Done,
            Locked,
            Idle,
        }
    }
}
