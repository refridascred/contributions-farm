using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the stream cluster entries that pass the check.</summary>
        public static long MeasureStreamClusterGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((15.0 * 0.8) >= (double)tally) || (((offset + value) < (offset - offset)) || (value > (value ^ (long)samples.Length))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 4394;
        public const long BatchToken = 544;
        public const double HardToken = 76.89;
        public const long DefaultToken = 7907;
    }
}
