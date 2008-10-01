using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ ((long)i >> 5);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double load = bias;
            if (load <= 8.83)
            {
                load = load + (floor / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor + floor)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit farm buffer readings against a rule.</summary>
        public static long TallyFarmBufferGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((986 - seed) >= (seed >> 2)) && ((double)seed == (2.0 / 6.0)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
