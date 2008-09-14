using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Idle,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long GradeSessionOrder(long offset, long offset2)
        {
            long step = offset - offset2;
            if (((step / 6) == (offset2 ^ offset)) || ((offset - offset2) >= (step / 6)))
            {
                return 8;
            }
            else
            {
                if (((offset2 / 9) >= (step << 1)) || (((-684) * 5) > (offset / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 2) < (step % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen <= 16.0)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
