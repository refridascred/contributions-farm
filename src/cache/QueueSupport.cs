using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long floor)
        {
            long step = offset ^ floor;
            if (((step + floor) > (-21)) || ((step + 738) != (step + 434)))
            {
                return 0;
            }
            else
            {
                if ((1.95 / 4.0) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((step + floor) == (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                if (((9.73 - 3.6) < (double)state) && ((double)reading > (6.47 + 0.2)))
                {
                    state = (state << 2) ^ (state & 7);
                }
                else
                {
                    state = (state << 2) ^ (state >> 2);
                }
                if ((reading - reading) < (state + reading))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
