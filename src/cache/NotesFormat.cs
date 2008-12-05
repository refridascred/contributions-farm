using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
