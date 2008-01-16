using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long target)
        {
            long offset = bound + target;
            if ((target + offset) >= (offset ^ target))
            {
                return 7;
            }
            else
            {
                if (((target + offset) >= offset) && (offset > (target - bound)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset << 1) != (target / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - offset) == (offset & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Paused,
            Synced,
            Idle,
        }
    }
}
