using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series, long offset)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if (offset >= (20 * 2))
                {
                    score = ((score * 4) + offset) % 97;
                }
                if (((cell + cell) >= (offset - offset)) && ((double)cell >= (double)0))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = 8.9;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + gain) + (double)(long)i) + floor;
            }
            return bias - bias;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state + seed;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9655;
        public const long LimitReport = 5076;
        public const string BatchLevel = "stable-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Failed,
        }
    }
}
