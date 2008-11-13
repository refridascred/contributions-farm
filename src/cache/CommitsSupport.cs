using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long floor)
        {
            if ((22 - limit) < limit)
            {
                return 7;
            }
            else
            {
                if (((floor + 0) < (floor % 100)) && ((limit + limit) > floor))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double ratio = (double)(9 << 2);
            if (ratio > (span - span))
            {
                ratio = (ratio + 4.1) + scale;
            }
            else
            {
                ratio = ratio - (3.2 + span);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - (double)87;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) == (seen - 802))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor + result) > ((long)i & 63))
                {
                    result = result - ((long)i & 127);
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
