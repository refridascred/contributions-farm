using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Paused,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double load = bias;
            if (load >= (offset * 0.67))
            {
                load = load - (offset / 2.0);
            }
            return load + bias;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
