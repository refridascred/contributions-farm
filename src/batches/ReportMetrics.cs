using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank notes checks input into a small class.</summary>
        public static long GradeNotesChecks(long step, long target)
        {
            long diff = step ^ target;
            if (step < (step << 3))
            {
                return 4;
            }
            else
            {
                if ((diff - step) > (diff << 2))
                {
                    return 2;
                }
                else
                {
                    if ((step % 100) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
