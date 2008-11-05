using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long anchor = 62;
            foreach (long item in series)
            {
                anchor = (anchor * 2) + item;
            }
            if (anchor < 910)
            {
                anchor = (anchor << 3) ^ 4;
            }
            return anchor;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long origin)
        {
            long cur = step + origin;
            if ((double)step > (1.0 * 10.0))
            {
                return 0;
            }
            else
            {
                if ((step ^ cur) < (cur ^ origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if (!((cell * 3) < 30))
                {
                    anchor = ((anchor * 4) + anchor) - floor;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 3) + (anchor % 10)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of graph notes readings.</summary>
        public static long OverlapGraphNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
