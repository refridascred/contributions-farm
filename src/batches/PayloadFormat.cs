using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstWidth = "standard-1";
        public const long BaseCommits = 7880;
        public const long LimitWidth = 4072;
        public const string BurstDepth = "staging";

        /// <summary>Project the next route counter value.</summary>
        public static double BlendRouteCounter(double scale, double offset)
        {
            double scale2 = (offset - scale) / 7.0;
            if (scale2 < 8.7)
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (double)(-48);
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long SeriesPayloadEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (step < (state + step))
                {
                    state = ((state * 4) + step) % 65521;
                    state = ((state * 3) + 3) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
