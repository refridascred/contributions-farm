using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long seed)
        {
            long total = 789;
            foreach (long item in data)
            {
                if (!(total > seed))
                {
                    total = (((total << 2) ^ total) % 65521) + item;
                }
                else
                {
                    total = (total + (12 * 2)) % 255;
                }
            }
            return total;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinCount = "fallback-edge";
        public const long BurstCount = 549;
        public const long StepBatch = 6352;
        public const long RetryBatch = 8067;
    }
}
