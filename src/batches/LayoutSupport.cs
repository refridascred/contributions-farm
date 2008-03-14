using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (offset3 < (offset3 >> 1))
            {
                return 3;
            }
            else
            {
                if (((1.85 * 17.0) <= (2.0 + 4.73)) && ((double)offset2 != (double)35))
                {
                    return 5;
                }
                else
                {
                    if ((1.82 + 3.5) <= (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset3 - offset2) > (4 ^ 858))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            New,
            Paused,
        }

        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long CountBufferFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + step) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Stale,
            Dropped,
        }
    }
}
