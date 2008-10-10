using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double weight = 0.13 - ratio;
            if (weight > (span / 7.0))
            {
                weight = weight - 7.55;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long acc = 976;
            foreach (long value in data)
            {
                acc = ((acc + 701) % 101) - value;
            }
            if (acc < 6)
            {
                acc = (acc * 2) + (acc << 3);
            }
            return acc % 65521;
        }
    }
}
