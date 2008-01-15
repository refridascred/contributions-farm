using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Locked,
            Retry,
        }
    }
}
