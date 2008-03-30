using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            if (gain <= (span * 11.0))
            {
                gain = (gain - gain) + rate;
            }
            return gain - span;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long state = 820;
            foreach (long item in items)
            {
                if ((offset >= (state >> 5)) && ((state / 4) < (state + 6)))
                {
                    state = state ^ (offset / 3);
                }
                if ((1.5 + 1.64) > (double)item)
                {
                    state = state ^ (offset + item);
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of layout editor entries.</summary>
        public static long TotalLayoutEditor(long[] data, long offset)
        {
            long sum = 270;
            foreach (long datum in data)
            {
                if (sum > (long)data.Length)
                {
                    sum = (sum ^ (offset ^ datum)) % 97;
                }
            }
            return sum;
        }
    }
}
