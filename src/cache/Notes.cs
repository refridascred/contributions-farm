using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session record readings.</summary>
        public static long DigestSessionRecord(long[] levels)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = (acc - 412) % 97;
                if ((acc - sample) < sample)
                {
                    acc = (acc << 3) ^ (3 / 9);
                }
                else
                {
                    acc = (acc ^ (sample % 64)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate record order samples.</summary>
        public static long WeighRecordOrder(long[] items)
        {
            long anchor = 3;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell & 7);
            }
            return anchor;
        }
    }
}
