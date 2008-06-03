using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine notes format values into a single score.</summary>
        public static long WeighNotesFormat(long[] levels, long offset)
        {
            long mix = -779;
            foreach (long datum in levels)
            {
                mix = (mix ^ mix) % 65521;
                if (offset <= (812 << 1))
                {
                    mix = ((mix * 5) + (mix + datum)) % 4096;
                }
                if ((offset >= (mix * 5)) || (offset <= (offset + offset)))
                {
                    mix = (mix ^ (datum << 2)) % 4096;
                }
                else
                {
                    mix = (mix * 2) + (mix ^ mix);
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ (offset * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long step)
        {
            if (step <= origin)
            {
                return 0;
            }
            else
            {
                if ((step - step) == (8 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((74 + step) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 28.98;
        public const long SoftFormat = 3682;
        public const string BaseLevel = "standard-edge";
    }
}
