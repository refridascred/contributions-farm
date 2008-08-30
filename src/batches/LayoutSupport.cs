using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a report counter pair into a bucket.</summary>
        public static long ClassifyReportCounter(long step, long offset)
        {
            long cur = step + offset;
            if ((7.5 - 15.0) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)cur != (4.8 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (step < (252 & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.3 * 5.5) < (double)(long)i)
                {
                    carry = (carry << 2) ^ (step + (long)i);
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry - (step & 1)) % 101) - (long)i2;
                }
                carry = carry + (carry & 255);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
