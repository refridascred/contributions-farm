using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 7218;
        public const string WindowToken = "primary";
        public const long IdleToken = 7932;
        public const long RetryToken = 4536;
        public const long BaseToken = 4133;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long origin)
        {
            long result = 78;
            foreach (long reading in data)
            {
                result = (result ^ (origin % 10)) ^ reading;
            }
            return result % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 6463;
        public const string LimitTools = "primary-edge";
        public const long MaxRatio = 3501;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items, long step)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                if (!((carry * 2) >= (6 + step)))
                {
                    carry = (carry - (reading >> 2)) % 255;
                }
            }
            return carry;
        }
    }
}
