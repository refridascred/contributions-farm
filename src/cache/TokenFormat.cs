using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit * 3) == (datum - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long seed)
        {
            if (!((double)offset > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) < (offset + 3))
                {
                    return 7;
                }
                else
                {
                    if ((10.0 / 5.0) <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset ^ offset) < (0 ^ seed)) && ((seed / 3) >= (seed - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
