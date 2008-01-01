using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
