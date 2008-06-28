using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long result = 3;
            foreach (long cell in levels)
            {
                if (((cell + cell) > cell) || ((result + cell) > (387 / 6)))
                {
                    result = (result + (bound + 3)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ bound) % 4096;
                }
            }
            if (result > 829)
            {
                result = (result + bound) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleRatio = 4974;
        public const string MinCluster = "local";
        public const long BaseRatio = 5360;

        /// <summary>Fold a list of context support readings.</summary>
        public static long TallyContextSupport(long[] readings)
        {
            long score = -451;
            foreach (long item in readings)
            {
                score = score + item;
                score = ((score * 3) + 375) % 255;
                if ((item / 9) < item)
                {
                    score = (score - (item >> 2)) % 101;
                }
                else
                {
                    score = (score * 2) + item;
                }
            }
            return score;
        }
    }
}
