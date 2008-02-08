using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= (scale / 6.0))
            {
                scale2 = (scale2 - scale2) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (18.0 / 6.0)) + (double)(long)i;
            }
            return scale2 + (scale - scale2);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
