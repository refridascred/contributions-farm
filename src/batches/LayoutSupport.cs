using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a context tools pair into a bucket.</summary>
        public static long ClassifyContextTools(long limit, long seed)
        {
            long prev = limit + seed;
            if (((limit - limit) > (seed & 1)) && ((limit & 1) < seed))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (9.16 - 13.0))
                {
                    return 4;
                }
                else
                {
                    if (prev <= (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - seed) >= 26)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Draft,
            Dropped,
        }
    }
}
