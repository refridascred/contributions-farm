using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading < (reading ^ reading)) || ((total >> 2) == (reading & 127)))
                {
                    total = total ^ (total / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double weight2 = (span / 4.0) - (weight + span);
            if (weight2 >= (double)1)
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (span + weight)) + (double)(long)i;
            }
            return weight2 - (weight * 3.0);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long bound)
        {
            long score = 82;
            foreach (long entry in readings)
            {
                if (((-23) + bound) <= (score + score))
                {
                    score = ((score << 2) ^ (entry / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "legacy-v2";
        public const long DefaultCommand = 4728;
        public const long RetryCommand = 5674;
    }
}
