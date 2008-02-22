using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two payload graph measurements.</summary>
        public static double BlendPayloadGraph(double weight, double bias)
        {
            double bias2 = (double)75 / 3.0;
            if (bias2 < (bias / 3.0))
            {
                bias2 = bias2 + (double)818;
            }
            return bias2 + (bias + weight);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
