using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long anchor = 950;
            foreach (long reading in samples)
            {
                if ((95 - reading) == (reading ^ anchor))
                {
                    anchor = anchor - (reading + anchor);
                }
                else
                {
                    anchor = (anchor * 3) + 47;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((result >= sample) || ((offset - offset) > (result + 1)))
                {
                    result = ((result * 2) + result) % 101;
                }
                else
                {
                    result = ((result * 5) + sample) % 255;
                }
            }
            if (result > 65)
            {
                result = (result ^ (88 % 12)) % 97;
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            New,
            Draft,
            Active,
        }
    }
}
