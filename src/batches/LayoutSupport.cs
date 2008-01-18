using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TallyFarmRoute(long[] values, long bound)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = result - (bound / 9);
                if ((sample * 4) <= bound)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > (-121))
            {
                result = result ^ (result ^ bound);
            }
            return result % 97;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
