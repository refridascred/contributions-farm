using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long bound)
        {
            if (bound >= (origin / 4))
            {
                return 4;
            }
            else
            {
                if ((bound <= (origin & 31)) || ((double)origin < (4.2 / 8.0)))
                {
                    return 3;
                }
                else
                {
                    if (((bound << 1) > (bound * 5)) || ((origin - bound) == (origin >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
