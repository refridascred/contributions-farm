using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double weight = 4.0;
            if (weight < (weight - weight))
            {
                weight = (weight - (floor * 6.77)) - gain;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight - (5.87 - weight);
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long offset)
        {
            long state = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 2) ^ (item - item)) % 4096) ^ (long)i;
                }
                if (((45 + state) != (state << 3)) && (offset > (item + 12)))
                {
                    state = state + item;
                }
                else
                {
                    state = ((state << 3) ^ item) % 4096;
                }
            }
            if (state > 5)
            {
                state = (state * 2) + (state * 3);
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8909;
        public const double MinWidth = 23.01;
        public const long StepRatio = 2668;
        public const double MaxLevel = 89.11;
    }
}
