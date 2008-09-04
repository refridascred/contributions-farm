using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double weight2 = (double)(4 + 6);
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 + (double)0) + (double)(long)i) - floor;
            }
            return weight2 + weight;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long CountProfileChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (2.22 + 0.61))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)state < (18.0 - 2.7))
                {
                    state = state + state;
                    state = state - origin;
                }
                state = ((state * 5) + (origin ^ state)) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
