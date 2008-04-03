using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank editor graph input into a small class.</summary>
        public static long SortEditorGraph(long origin, long step)
        {
            long span = origin + step;
            if (span > (origin ^ step))
            {
                return 6;
            }
            else
            {
                if (((7.81 - 0.5) <= (double)step) || ((14 + span) <= (step - span)))
                {
                    return 7;
                }
                else
                {
                    if (span >= (origin + 230))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 <= origin) && ((step << 1) > (835 + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 52.68;
        public const double BaseBudget = 42.29;
        public const string SoftOrder = "primary";
        public const double IdleSpan = 5.44;
        public const long BatchBudget = 764;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
