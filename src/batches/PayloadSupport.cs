using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor2 >> 5) > floor2)
            {
                return 4;
            }
            else
            {
                if ((floor2 ^ 184) < 37)
                {
                    return 7;
                }
                else
                {
                    if ((floor2 / 8) < (62 ^ offset))
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
