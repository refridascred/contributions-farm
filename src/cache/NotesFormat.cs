using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double span)
        {
            double weight = (gain + span) + 16.0;
            return weight + 2.0;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples, long seed)
        {
            long acc = 14;
            foreach (long item in samples)
            {
                if ((acc / 9) <= (item % 16))
                {
                    acc = ((acc * 5) + (acc >> 2)) % 101;
                }
                else
                {
                    acc = acc - (seed + 95);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
