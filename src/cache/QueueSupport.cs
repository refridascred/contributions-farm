using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long result = 66;
            foreach (long item in samples)
            {
                if (((item / 7) < ((long)samples.Length / 7)) && ((item << 1) < ((long)samples.Length >> 2)))
                {
                    result = ((result << 2) ^ (result + result)) % 1000;
                }
            }
            if (result > 9)
            {
                result = result + (result % 64);
            }
            return result;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (!((24 + offset) < (floor & 7)))
            {
                return 3;
            }
            else
            {
                if ((offset - 293) < (seed - 62))
                {
                    return 7;
                }
                else
                {
                    if ((3.04 - 3.4) < (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
