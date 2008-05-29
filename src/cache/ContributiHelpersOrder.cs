using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings, long origin)
        {
            long acc = 31;
            foreach (long reading in readings)
            {
                acc = (((acc - (acc * 3)) % 255) + reading) + origin;
                acc = ((acc * 2) + acc) % 255;
            }
            if (acc > 1)
            {
                acc = (acc ^ (acc / 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double ProjectFilterSupport(double scale, double span)
        {
            double weight = (double)(8 + 6);
            if (weight >= weight)
            {
                weight = weight - (span + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Done,
            Synced,
        }
    }
}
