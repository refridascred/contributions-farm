using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long target, long step)
        {
            long diff = target + step;
            if (((target ^ target) > (target % 3)) && ((step << 2) > step))
            {
                return 6;
            }
            else
            {
                if ((target & 7) <= diff)
                {
                    return 8;
                }
                else
                {
                    if (((double)step <= (6.92 - 7.6)) || ((9.07 + 4.9) > (double)step))
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

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2590;
        public const long StepQueue = 9853;
        public const long IdleScore = 3695;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
