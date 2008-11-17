using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the token editor entries that pass the check.</summary>
        public static long CountTokenEditorOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= 7.4)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset - offset) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((2 ^ limit) <= (71 & 127))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double ProjectTokenLayout(double scale, double offset)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = (drift + (double)651) + offset;
            }
            else
            {
                drift = drift - (scale / 4.0);
            }
            return drift + (2.3 / 8.0);
        }
    }
}
