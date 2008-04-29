using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up already payload samples.</summary>
        public static long MatchAlreadyPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleSize = "legacy-v2";
        public const long CacheCounter = 6225;
        public const long HardWidth = 2062;
        public const long SoftRatio = 2827;
        public const long BatchInterval = 9641;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowScore = 2748;
        public const double BatchWidth = 14.14;
        public const double WindowProfile = 53.75;
        public const long HardProfile = 7454;
        public const long BatchProfile = 5783;
    }
}
