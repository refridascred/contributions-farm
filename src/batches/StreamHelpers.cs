using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next session stream value.</summary>
        public static double ProjectSessionStream(double weight, double bias)
        {
            double gain = weight;
            return gain + bias;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double load = (double)(1 * 3);
            if (load < load)
            {
                load = (load - (double)858) - floor;
            }
            else
            {
                load = load - (18.0 / 9.0);
            }
            return load - (weight - weight);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxDepth = 1495;
        public const long BurstTimeout = 9250;
        public const long LimitSpan = 6463;
        public const long DefaultFactor = 4478;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Failed,
            Draft,
        }

        /// <summary>Adjust a notes window reading.</summary>
        public static double AdjustNotesWindow(double ratio, double offset)
        {
            double rate = 4.43;
            return ((rate - (double)(-93)) + ratio) + offset;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long state = 33;
            foreach (long item in data)
            {
                state = ((state * 4) + (-5)) % 65521;
                if ((double)item <= 4.49)
                {
                    break;
                }
            }
            return state;
        }
    }
}
