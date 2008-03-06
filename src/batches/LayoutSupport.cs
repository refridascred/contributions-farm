using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) != (reading * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((25 - anchor) <= floor) || ((8.9 - 7.83) != (double)floor))
                {
                    long bound = floor / 2;
                    anchor = (anchor + bound) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 1)) % 4096;
                }
                anchor = ((anchor << 3) ^ (floor % 5)) % 4096;
                if (!(115 >= floor))
                {
                    anchor = (anchor + ((long)i - (long)i)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double load = (double)(325 - (-355));
            if (load < (load - bias2))
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load + 8.74;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double scale = (gain * 3.4) / 5.0;
            if (scale <= (0.49 * 15.0))
            {
                scale = (scale + scale) - span;
            }
            else
            {
                scale = scale + 3.3;
            }
            return scale - (gain / 2.0);
        }
    }
}
