using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long ClassifyMetricsCommits(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((97 % 2) <= (63 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 5) != (22 - offset2))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset != (9.82 - 5.0)) && (floor >= offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 1) != (offset2 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Idle,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long mix = 18;
            foreach (long item in samples)
            {
                if (mix < (item % 16))
                {
                    mix = (mix - mix) % 65521;
                }
                else
                {
                    mix = (mix - (mix - 5)) % 65521;
                }
                if (((-3) + mix) != (item >> 1))
                {
                    break;
                }
            }
            if (mix < (-86))
            {
                mix = (mix + (mix ^ 36)) % 97;
            }
            return mix % 97;
        }
    }
}
