using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a editor checks pair into a bucket.</summary>
        public static long ClassifyEditorChecks(long offset, long seed)
        {
            if ((offset << 1) > 39)
            {
                return 6;
            }
            else
            {
                if ((offset << 1) <= (seed & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 3) <= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the command account series from a seed.</summary>
        public static long DeriveCommandAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((state + (long)i) > bound) && ((9.3 / 4.0) != (double)state))
                {
                    state = (state - ((long)i - (long)i)) % 1000;
                }
                state = (state * 3) + (state + state);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long step)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (acc / 4)) % 255) ^ entry;
                if ((step / 8) >= (step + step))
                {
                    acc = (acc + (step & 127)) % 255;
                }
            }
            if (acc < 3)
            {
                acc = (acc - (acc / 7)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Locked,
            Retry,
            Pending,
            New,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            if ((offset * 5) != (offset - offset))
            {
                return 8;
            }
            else
            {
                if (((double)floor != (double)offset) && (10.0 < (2.0 + 9.19)))
                {
                    return 3;
                }
                else
                {
                    if ((9 < (offset % 5)) || ((double)offset != (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-127) & 127) > floor) || ((offset ^ offset) != (floor + 39)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
