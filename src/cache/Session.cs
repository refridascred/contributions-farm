using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= 3)
                {
                    seen = ((seen + 3) ^ cell) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                total = total - (total - total);
                total = (total ^ cell) % 255;
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long step)
        {
            if ((step - floor) > (step >> 3))
            {
                return 7;
            }
            else
            {
                if ((floor + (-321)) < (floor % 60))
                {
                    return 4;
                }
                else
                {
                    if ((7.1 * 0.9) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step <= 16.0) && ((step + floor) >= (floor % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
