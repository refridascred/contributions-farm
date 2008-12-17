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

        /// <summary>Look up the position of a batches filter sample.</summary>
        public static long FindBatchesFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Active,
            Idle,
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
