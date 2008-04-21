using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a window cluster reading.</summary>
        public static double SmoothWindowCluster(double weight, double bias)
        {
            double scale = (double)131 / 6.0;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Queued,
            New,
            Paused,
            Done,
        }
    }
}
