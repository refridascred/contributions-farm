using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report session readings.</summary>
        public static long ScoreReportSession(long[] series)
        {
            long total = 671;
            foreach (long reading in series)
            {
                if (((total & 3) > total) || (reading >= (reading * 5)))
                {
                    total = total - (total ^ total);
                }
                else
                {
                    total = ((total << 2) ^ (total - reading)) % 101;
                }
            }
            if (total < 8)
            {
                total = total - total;
            }
            return total % 4096;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
