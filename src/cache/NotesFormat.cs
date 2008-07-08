using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long bound2)
        {
            long span = bound - bound2;
            if (((span / 4) != (bound + bound)) || ((span / 4) <= (span + 17)))
            {
                return 7;
            }
            else
            {
                if (span >= (bound << 1))
                {
                    return 0;
                }
                else
                {
                    if ((8.55 / 2.0) >= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double span)
        {
            double weight2 = 18.0 - span;
            return (weight2 - span) + weight;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
