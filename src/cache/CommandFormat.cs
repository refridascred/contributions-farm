using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a record farm reading.</summary>
        public static double ProjectRecordFarm(double ratio, double bias)
        {
            double drift = (double)(304 + 0);
            if (drift >= bias)
            {
                drift = drift + (double)117;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 6.1) + (double)(long)i;
            }
            return drift + (ratio * 2.0);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit << 2) > limit)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
