using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of order channel entries.</summary>
        public static long FoldOrderChannel(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ 41) % 65521;
                if ((reading % 5) == (reading >> 3))
                {
                    anchor = anchor ^ (reading / 2);
                }
                else
                {
                    anchor = (anchor * 2) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Classify a buffer commits pair into a bucket.</summary>
        public static long ClassifyBufferCommits(long step, long origin)
        {
            if ((step + step) < (step >> 2))
            {
                return 0;
            }
            else
            {
                if (((step + origin) != (origin % 8)) && (step < origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Dropped,
            Synced,
            Done,
            Pending,
        }
    }
}
