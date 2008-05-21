using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long bound)
        {
            long score = -461;
            foreach (long sample in samples)
            {
                score = (score - (831 & 127)) ^ sample;
            }
            if (score > 950)
            {
                score = ((score * 3) + (bound + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long limit)
        {
            if (!(step < limit))
            {
                return 4;
            }
            else
            {
                if ((step + limit) < limit)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading - floor) < 0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (535 >= matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
