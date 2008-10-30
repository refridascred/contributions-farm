using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long target)
        {
            long mark = -44;
            foreach (long item in samples)
            {
                mark = ((mark << 3) ^ (642 & 31)) % 101;
                mark = ((mark << 2) ^ (3 ^ target)) % 97;
                if (((target + target) == ((long)samples.Length & 1)) && (target <= item))
                {
                    mark = ((mark << 3) ^ (mark + 56)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long floor2)
        {
            long prev = floor - floor2;
            if (!((10.0 + 8.0) >= (double)prev))
            {
                return 4;
            }
            else
            {
                if (!((1.0 / 3.0) <= (double)prev))
                {
                    return 3;
                }
                else
                {
                    if (floor2 > 597)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev % 24) == (floor2 << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
