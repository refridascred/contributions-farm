using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a payload format counter forward.</summary>
        public static long StepPayloadFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long limit)
        {
            long mix = 69;
            foreach (long datum in samples)
            {
                mix = (mix + (mix * 4)) - limit;
                if (datum >= 745)
                {
                    mix = mix - 3;
                }
                if ((datum - 18) > mix)
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = (mix + (mix % 60)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double weight2 = (span * 4.6) / 6.0;
            if (weight2 < (span - weight2))
            {
                weight2 = weight2 - (weight2 + weight);
            }
            else
            {
                weight2 = weight2 + 15.0;
            }
            return weight2 - 12.0;
        }

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long MeasureBufferProfileMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)datum > (10.0 * 13.0)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
