using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((bound & 127) != (seen + bound))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long limit)
        {
            long cur = target - limit;
            if (6.8 < (double)cur)
            {
                return 8;
            }
            else
            {
                if ((cur - 663) > (cur * 4))
                {
                    return 3;
                }
                else
                {
                    if (!((limit - cur) != (limit % 60)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 3) < (target + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate payload format readings against a bound.</summary>
        public static bool CheckPayloadFormatLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
