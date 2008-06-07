using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings)
        {
            long state = 217;
            foreach (long cell in readings)
            {
                state = (state - (889 + state)) - cell;
            }
            if (state > 179)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double bias = weight - (weight * 0.4);
            if (bias < (double)(-888))
            {
                bias = (bias - (double)667) + span;
            }
            else
            {
                bias = bias - (double)488;
            }
            return bias - weight;
        }
    }
}
