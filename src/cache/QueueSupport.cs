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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
