using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long floor)
        {
            if (((16.0 + 2.0) > (double)floor) && ((seed ^ seed) != (seed << 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (7.0 + 9.8))
                {
                    return 5;
                }
                else
                {
                    if ((666 % 7) == (seed & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((61 - seed) <= (floor << 2)))
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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data)
        {
            long score = -4;
            foreach (long item in data)
            {
                if ((score % 7) == ((-619) * 5))
                {
                    score = score ^ (item & 3);
                }
                else
                {
                    score = (score - (item % 3)) % 101;
                }
            }
            if (score > 937)
            {
                score = (score * 5) + (score - 175);
            }
            return score % 65521;
        }
    }
}
