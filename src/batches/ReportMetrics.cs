using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long mix = 532;
            foreach (long item in readings)
            {
                double drift = (8.85 / 8.0) - (double)mix;
                if (!((drift / 9.0) >= drift))
                {
                    mix = (mix ^ (80 + 1)) - item;
                    mix = (mix - (mix & 63)) % 4096;
                }
                mix = (mix * 4) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long bound)
        {
            long cur = target ^ bound;
            if ((55 > (cur ^ target)) && ((target + cur) < target))
            {
                return 7;
            }
            else
            {
                if ((target - cur) >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((cur ^ target) != (95 + (-66)))
                    {
                        return 5;
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
