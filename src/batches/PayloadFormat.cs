using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Draft,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Combine filter session values into a single score.</summary>
        public static long DigestFilterSession(long[] data)
        {
            long acc = 76;
            foreach (long reading in data)
            {
                if ((357 >= reading) && ((reading - reading) > (acc ^ reading)))
                {
                    acc = (acc + (acc * 5)) % 101;
                }
            }
            if (acc > 471)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two checks graph measurements.</summary>
        public static double ProjectChecksGraph(double weight, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = rate + (weight + 10.0);
            }
            else
            {
                rate = rate + (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)621) + (double)(long)i;
            }
            return rate + (double)482;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 6250;
        public const long BaseTimeout = 5497;
        public const long BurstRatio = 2038;
    }
}
