using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 1))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long bound)
        {
            long lane = step - bound;
            if ((1.4 + 7.4) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((step - step) > (lane + step)))
                {
                    return 0;
                }
                else
                {
                    if ((87 >= (step & 3)) || ((bound * 4) < (bound - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
