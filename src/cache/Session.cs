using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= scale2)
            {
                scale2 = scale2 + 6.55;
            }
            else
            {
                scale2 = scale2 + (scale2 - offset);
            }
            return scale2 + 13.0;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseSize = "primary-v2";
        public const string BurstSpan = "local-v2";
        public const long SoftScore = 5996;
        public const long IdlePayload = 7272;
        public const string StepLevel = "stable-v2";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
