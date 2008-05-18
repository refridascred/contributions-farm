using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long floor)
        {
            long state = 331;
            foreach (long reading in series)
            {
                if ((floor >> 5) == (floor << 3))
                {
                    state = (state + state) + reading;
                }
                if ((14 - floor) != (floor << 1))
                {
                    break;
                }
                else
                {
                    state = (state - (state >> 1)) % 65521;
                }
                state = (state - (438 << 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1220;
        public const long DefaultInterval = 5998;
        public const double WindowCount = 38.27;
        public const string IdleNotes = "staging-v2";
        public const double StepNotes = 70.93;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double weight = gain;
            if (weight < gain)
            {
                weight = (weight - gain) + offset;
            }
            return weight - weight;
        }
    }
}
