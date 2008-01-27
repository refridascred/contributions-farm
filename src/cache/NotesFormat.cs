using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double ratio = (double)(93 << 3);
            if (ratio > (floor - ratio))
            {
                ratio = ratio - 15.0;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)4) + (double)(long)i;
            }
            return ratio + (weight * 18.0);
        }

        /// <summary>Accumulate metrics already samples.</summary>
        public static long DigestMetricsAlready(long[] samples)
        {
            long mark = 44;
            foreach (long entry in samples)
            {
                if (((entry << 2) < (mark - entry)) || ((790 - entry) == (entry - mark)))
                {
                    mark = mark + (entry * 5);
                }
            }
            if (mark < 57)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
