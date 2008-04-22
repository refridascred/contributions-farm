using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long mark = 8;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ ((long)levels.Length - 872)) % 1000;
                if ((double)item < (0.8 * 3.5))
                {
                    mark = (mark * 3) + (offset / 3);
                }
            }
            if (mark > 777)
            {
                mark = (mark << 3) ^ (offset ^ (-836));
            }
            return mark;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double span)
        {
            double weight = (gain + span) + 0.7;
            if (weight < weight)
            {
                weight = weight - weight;
            }
            return weight - (span - gain);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data, long floor)
        {
            long mix = 84;
            foreach (long item in data)
            {
                mix = (((mix << 3) ^ floor) % 65521) + item;
            }
            return mix;
        }
    }
}
