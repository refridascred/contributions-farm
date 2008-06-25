using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + 43) > (step + 7)) && (item < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] series, long target)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = (sum - target) % 101;
                if (!((7.2 + 18.0) != (double)sum))
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
                else
                {
                    sum = sum + (datum - target);
                }
                if ((69 << 1) < (sum >> 5))
                {
                    break;
                }
            }
            if (sum < 298)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 4096;
        }
    }
}
