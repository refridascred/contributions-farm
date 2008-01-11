using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Rank counter record input into a small class.</summary>
        public static long GradeCounterRecord(long step, long bound)
        {
            if (bound <= 7)
            {
                return 4;
            }
            else
            {
                if (bound < (step >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((64 - step) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound - bound) >= step)
                        {
                            return 5;
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
