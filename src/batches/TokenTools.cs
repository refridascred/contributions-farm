using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark - step) ^ (long)i2;
                }
                mark = mark + mark;
                if ((mark & 3) >= mark)
                {
                    mark = mark ^ ((long)i + 683);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double scale = offset;
            if (scale > (scale * 19.0))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (weight / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (weight / 7.0)) + (double)(long)i;
            }
            return scale + weight;
        }
    }
}
