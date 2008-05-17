using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                long cur = acc;
                if ((71 <= (cur >> 4)) || (acc <= 4))
                {
                    cur = (cur + acc) % 1000;
                }
                if ((((long)i + (-66)) > (cur << 1)) || (acc < (target >> 5)))
                {
                    acc = acc + (cur - acc);
                    cur = (cur * 2) + (target - (long)i);
                    continue;
                }
                else
                {
                    acc = (acc * 2) + (acc - 970);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
