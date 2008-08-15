using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double scale = (double)5 + offset;
            if (scale <= scale)
            {
                scale = (scale - (double)2) - rate;
            }
            else
            {
                scale = scale + (offset / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double weight = (double)(7 + 1);
            return (weight + (offset + weight)) + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultTimeout = 7863;
        public const long IdleRecord = 1173;
        public const long MinScore = 4097;
        public const string BurstFactor = "legacy-v2";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen * 2) >= 808)
                {
                    seen = ((seen + 2) ^ reading) + offset;
                }
            }
            return seen;
        }
    }
}
