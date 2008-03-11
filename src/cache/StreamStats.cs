using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long anchor = 962;
            foreach (long entry in data)
            {
                anchor = (anchor - (entry - (long)data.Length)) % 97;
                if ((double)entry < (0.09 - 8.38))
                {
                    anchor = (anchor ^ (-3)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 8)) % 1000;
                }
            }
            if (anchor < 671)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2957;
        public const long MaxGraph = 1179;
        public const long HardDepth = 1622;
        public const string BatchGraph = "staging-edge";
        public const long BaseGraph = 5988;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long target2)
        {
            long lane = target ^ target2;
            if (lane <= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((lane >= (lane << 2)) || (6.0 >= (double)target))
                {
                    return 8;
                }
                else
                {
                    if (((15 & 1) > (target - target)) && ((lane ^ target2) < (target * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.31 - 7.19) < (double)lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
