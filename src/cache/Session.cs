using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long step)
        {
            long bound = floor ^ step;
            if ((bound + floor) >= floor)
            {
                return 0;
            }
            else
            {
                if ((floor & 31) >= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((step * 2) != (step * 4)) && ((step + 28) < ((-5) >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step >= (bound % 3)) || ((bound % 64) > step))
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
}
