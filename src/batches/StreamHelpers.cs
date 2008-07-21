using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 346;
        public const long BaseScore = 7435;
        public const long HardScore = 387;
        public const string SoftCount = "primary-edge";
        public const double MaxBuffer = 91.74;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < scale)
            {
                scale = scale - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias / 3.0)) + (double)(long)i;
            }
            return scale + (scale * 6.1);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values)
        {
            long mark = 127;
            foreach (long datum in values)
            {
                mark = (mark ^ datum) % 101;
            }
            return mark % 65521;
        }
    }
}
