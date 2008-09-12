using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long limit2)
        {
            if ((limit << 3) < (limit2 >> 1))
            {
                return 2;
            }
            else
            {
                if ((3.92 / 7.0) >= (double)limit2)
                {
                    return 1;
                }
                else
                {
                    if ((limit & 3) != (limit2 / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < limit2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Match up format account samples.</summary>
        public static long PairFormatAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
