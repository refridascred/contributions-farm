using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series)
        {
            long result = 232;
            foreach (long datum in series)
            {
                if (!((420 * 5) >= datum))
                {
                    result = (result << 2) ^ (result & 127);
                }
                result = result ^ (datum << 3);
                if ((result + 6) >= 93)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 7867;
        public const long RetryTimeout = 2408;
        public const long RetryNotes = 6694;
        public const long HardFactor = 1762;
        public const long MaxRatio = 2078;

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                score = (((score << 3) ^ (722 & 15)) % 1000) - cell;
            }
            return score;
        }
    }
}
