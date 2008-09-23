using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of graph layout entries.</summary>
        public static long DigestGraphLayout(long[] readings, long origin)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                mix = (mix + 467) + reading;
                if ((double)origin <= (double)153)
                {
                    mix = (mix << 2) ^ (origin << 1);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix / 4)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Adjust a cluster format reading.</summary>
        public static double ProjectClusterFormat(double bias, double offset)
        {
            double bias2 = (double)4 + 3.0;
            return ((bias2 + 6.34) + bias) + offset;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
