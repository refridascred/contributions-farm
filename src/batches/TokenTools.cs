using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] data)
        {
            long state = 18;
            foreach (long datum in data)
            {
                state = ((state - state) % 101) + datum;
                state = (state ^ (842 << 1)) % 1000;
            }
            return state;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long bound, long step)
        {
            if (bound > (step % 10))
            {
                return 5;
            }
            else
            {
                if ((step - bound) < (7 << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (7.1 + 8.09)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 * 9.37) != (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
