using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double bias = (double)(90 / 9);
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (ratio - bias)) - (double)(long)i;
            }
            return bias - offset;
        }
    }
}
