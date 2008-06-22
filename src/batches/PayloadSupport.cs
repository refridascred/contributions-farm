using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long target)
        {
            long span = step - target;
            if ((span + span) > (step + 94))
            {
                return 8;
            }
            else
            {
                if (((span / 6) != (target + step)) || ((step & 7) != (8 >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((target * 2) >= (49 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span << 2) != (span + step)) && ((step - step) == (target & 31)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
