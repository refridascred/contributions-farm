using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long RankPayloadFormat(long target, long bound)
        {
            long step = target ^ bound;
            if (((target + bound) <= target) && ((step / 4) != (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((bound + target) < (step ^ 6))
                {
                    return 6;
                }
                else
                {
                    if ((double)step == (6.3 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > (85 >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits contributi samples.</summary>
        public static long TallyCommitsContributi(long[] values)
        {
            long result = 89;
            foreach (long reading in values)
            {
                result = result ^ reading;
                if ((reading - 685) >= (result << 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Look up the position of a token metric sample.</summary>
        public static long LocateTokenMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
