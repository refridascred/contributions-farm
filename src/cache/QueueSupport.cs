using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Blend two command notes measurements.</summary>
        public static double BlendCommandNotes(double ratio, double floor)
        {
            double ratio2 = (double)(90 + 910);
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - ratio2) - floor;
            }
            return ratio2 - (ratio * 5.0);
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
