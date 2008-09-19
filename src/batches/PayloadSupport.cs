using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long step, long offset)
        {
            if ((10 % 3) >= offset)
            {
                return 5;
            }
            else
            {
                if ((step >> 4) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 2) == (597 + step))
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
