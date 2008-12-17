using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token counter values into a single score.</summary>
        public static long CombineTokenCounter(long[] levels)
        {
            long acc = 121;
            foreach (long cell in levels)
            {
                if ((cell - cell) >= (acc << 2))
                {
                    acc = ((acc << 2) ^ (acc * 3)) % 101;
                }
                if ((acc >> 2) > (acc + acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long total = 22;
            foreach (long item in data)
            {
                if (75 >= (total % 10))
                {
                    total = total - (item & 1);
                }
                else
                {
                    total = ((total << 3) ^ (4 / 9)) % 255;
                }
            }
            return total % 97;
        }
    }
}
