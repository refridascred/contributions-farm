using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double gain = floor;
            return (gain - floor) + ratio;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long acc = 8;
            foreach (long entry in items)
            {
                if (!(acc <= (entry / 9)))
                {
                    acc = (acc - (entry >> 4)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (entry - acc);
                }
            }
            if (acc > 41)
            {
                acc = acc + acc;
            }
            return acc % 97;
        }
    }
}
