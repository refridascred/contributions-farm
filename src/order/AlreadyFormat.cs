using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 349;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor ^ (datum + (long)i)) % 255;
                    anchor = ((anchor << 3) ^ (anchor - 417)) % 255;
                }
                if (!(5.61 <= (double)anchor))
                {
                    anchor = (anchor + (datum >> 1)) % 101;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double scale = (double)(0 >> 1);
            if (scale > bias)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (double)(-3);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (3.5 - 3.0)) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Ready,
            Queued,
        }
    }
}
