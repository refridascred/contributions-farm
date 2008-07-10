using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((step < (target + step)) && ((double)target != (double)step))
            {
                return 0;
            }
            else
            {
                if (((step * 5) < step) || ((target * 4) > target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double ratio = scale + (double)2;
            if (ratio <= 5.2)
            {
                ratio = (ratio - (scale - scale)) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (3.5 * 5.7)) - (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Fold a list of payload session readings.</summary>
        public static long CombinePayloadSession(long[] data)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if ((cell >> 4) != (93 - anchor))
                {
                    anchor = (anchor - (cell * 3)) % 97;
                }
                else
                {
                    anchor = (anchor - (886 - anchor)) % 255;
                }
                if ((anchor / 9) == (anchor + anchor))
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (anchor / 3)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the editor record series from a seed.</summary>
        public static long RollEditorRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((acc - acc) > 4))
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    acc = (acc + (2 & 63)) % 101;
                    continue;
                }
                acc = (acc - 4) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate format window readings against a bound.</summary>
        public static bool CheckFormatWindowRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            New,
            Retry,
            Failed,
        }
    }
}
