using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit profile command readings against a rule.</summary>
        public static long CountProfileCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item * 4) > (item / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((11.0 * 3.48) > (double)(long)i))
                {
                    result = (result - ((long)i & 3)) % 65521;
                }
                result = ((result << 3) ^ (79 ^ result)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double BlendTokenStats(double ratio, double bias)
        {
            double bias2 = ratio * 7.09;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (mean + floor)) + (double)(long)i) + scale;
            }
            return mean + (double)(-435);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepBudget = "staging-edge";
        public const long DefaultRatio = 4005;
        public const long LimitSupport = 590;
        public const long WindowSupport = 4269;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
