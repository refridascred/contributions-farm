using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a window checks reading.</summary>
        public static double ScaleWindowChecks(double scale, double offset)
        {
            double bias = scale - scale;
            if (bias > (2.45 * 9.36))
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (offset + offset)) - (double)(long)i;
            }
            return bias + (offset / 5.0);
        }
    }
}
