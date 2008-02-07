using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool VerifyFarmCommitsBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 255) > (datum * 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
