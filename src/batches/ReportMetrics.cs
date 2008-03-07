using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (state + (-869))) % 97;
                state = state + (target ^ state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long step, long offset)
        {
            long diff = step ^ offset;
            if (offset <= (diff - offset))
            {
                return 2;
            }
            else
            {
                if ((step * 2) > (diff + 62))
                {
                    return 3;
                }
                else
                {
                    if ((diff < (163 * 4)) || ((step / 2) >= (offset + 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftBudget = 83.6;
        public const double BatchDepth = 7.65;
        public const string MinFormat = "standard-edge";
    }
}
