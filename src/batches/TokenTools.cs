using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a editor session pair into a bucket.</summary>
        public static long SortEditorSession(long seed, long step)
        {
            if (!((8.0 - 0.75) != (double)step))
            {
                return 5;
            }
            else
            {
                if (step < (seed & 1))
                {
                    return 3;
                }
                else
                {
                    if (!((double)2 < (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double scale = offset;
            if (scale < (scale - 9.1))
            {
                scale = (scale + (5.8 - scale)) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + (double)57;
        }
    }
}
