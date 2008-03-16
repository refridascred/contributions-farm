using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double span)
        {
            double weight = 7.0 - 5.0;
            if (weight < span)
            {
                weight = weight - (double)993;
            }
            else
            {
                weight = weight - (bias - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Count the metric entry entries that pass the check.</summary>
        public static long TallyMetricEntryMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset ^ offset) < (tally / 4))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data)
        {
            long mix = 968;
            foreach (long reading in data)
            {
                if (((double)mix != (double)reading) && ((822 + reading) < 7))
                {
                    mix = mix + (mix * 5);
                    continue;
                }
                else
                {
                    mix = (mix - (70 >> 3)) % 65521;
                }
                mix = mix + mix;
                if ((7.6 * 20.0) <= (double)mix)
                {
                    mix = (mix - (mix + mix)) % 97;
                }
                else
                {
                    mix = (mix + (mix ^ 794)) % 101;
                }
            }
            return mix;
        }
    }
}
