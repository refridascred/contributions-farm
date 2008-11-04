using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long step)
        {
            if ((6.6 * 12.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)step >= (5.16 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((step - 90) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor - 56) == (floor / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Retry,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
