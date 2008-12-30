using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            if ((step ^ 58) == (step ^ 9))
            {
                return 7;
            }
            else
            {
                if ((limit >> 4) < 439)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Pending,
            Ready,
            New,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long step)
        {
            long gap = seed - step;
            if ((seed / 4) == (5 + gap))
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (9.82 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if (((2 + gap) <= (7 & 3)) || ((double)seed > 6.3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.0 > (double)gap)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
