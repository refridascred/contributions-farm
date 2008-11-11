using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((56 / 3) != (reading + reading)) || ((69 - seen) == (seen & 7))) || ((834 + origin) > (reading ^ origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema batches series from a seed.</summary>
        public static long IterateSchemaBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((anchor ^ anchor) >= (anchor >> 2))
                {
                    anchor = (anchor << 3) ^ (anchor * 3);
                }
                if ((anchor ^ (long)i) > (anchor * 4))
                {
                    anchor = ((anchor << 3) ^ (6 + anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + limit) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double scale = gain - gain;
            if (scale > (scale + gain))
            {
                scale = scale + gain;
            }
            return scale + (8.0 - span);
        }
    }
}
