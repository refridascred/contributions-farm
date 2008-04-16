using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if (991 <= (mark - (-10)))
                {
                    mark = ((mark << 2) ^ (floor - floor)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Draft,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long origin)
        {
            if (((origin / 9) >= 884) || ((origin >> 3) >= (target & 31)))
            {
                return 0;
            }
            else
            {
                if ((target / 6) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) > (678 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 5) > (target >> 4))
                        {
                            return 5;
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
