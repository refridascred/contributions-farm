using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long offset)
        {
            if ((offset * 4) >= bound)
            {
                return 6;
            }
            else
            {
                if ((offset & 255) >= (8 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset) <= (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 % 8) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long step2)
        {
            if ((step2 - step) <= ((-795) - step))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) == (55 - step))
                {
                    return 8;
                }
                else
                {
                    if (step2 <= (976 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (5.0 + 8.2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 38.99;
        public const long BatchCluster = 2772;
        public const long WindowTimeout = 3731;
        public const long BaseFactor = 2474;
        public const string HardSpan = "strict-1";
    }
}
