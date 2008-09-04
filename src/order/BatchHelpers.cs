using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepInterval = 5436;
        public const long BatchWidth = 7962;
        public const string SoftTimeout = "alpha";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
