using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (ratio2 - ratio)) - floor;
            }
            return ratio2 - (ratio2 / 9.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "latest-1";
        public const string BaseFactor = "alpha-v2";
        public const long WindowScore = 2904;
        public const long StepFilter = 5424;
    }
}
