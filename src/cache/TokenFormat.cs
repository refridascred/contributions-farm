using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long offset)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                if ((reading >= (anchor >> 3)) && (((-1) - reading) < (reading + anchor)))
                {
                    anchor = (anchor ^ 62) - offset;
                }
                else
                {
                    anchor = anchor ^ (anchor >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double weight2 = 6.3 * 7.45;
            return ((weight2 + (double)111) + weight) + offset;
        }
    }
}
