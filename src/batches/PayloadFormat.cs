using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long bound)
        {
            long step2 = step - bound;
            if (step <= step2)
            {
                return 7;
            }
            else
            {
                if ((5 & 15) == (step2 >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((step2 & 255) != (step - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long mark = 5;
            foreach (long entry in data)
            {
                if (!((entry - mark) < 504))
                {
                    mark = (mark - (-148)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Idle,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxRatio = 4826;
        public const long SoftFormat = 2075;
        public const long DefaultRatio = 9432;
    }
}
