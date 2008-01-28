using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Pending,
            New,
            Queued,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Grade a stream batch value against two limits.</summary>
        public static long ClassifyStreamBatch(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if (((double)(-5) != (double)origin) || ((origin + (-15)) >= (origin >> 5)))
            {
                return 2;
            }
            else
            {
                if (13.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + offset2) < (offset2 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((31 >> 5) > (offset2 & 1)) || ((origin >> 5) >= (origin << 2)))
                        {
                            return 6;
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
