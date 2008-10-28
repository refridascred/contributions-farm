using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long ScoreStatsQueue(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                if (((reading - 234) >= 86) || (9.9 <= (double)reading))
                {
                    anchor = ((anchor * 2) + (90 % 60)) % 65521;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = anchor - (anchor - reading);
                if ((reading & 127) < (anchor - anchor))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + (limit * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}
