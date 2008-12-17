using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series)
        {
            long acc = 853;
            foreach (long reading in series)
            {
                if (((reading + reading) >= (acc / 9)) && ((reading + 104) > (24 / 9)))
                {
                    acc = (acc + (acc << 2)) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (972 % 12)) % 1000;
                }
                if ((double)reading < (10.0 / 3.0))
                {
                    break;
                }
            }
            return acc;
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
