using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = (score << 2) ^ (datum % 10);
                if ((double)score == (1.88 - 6.4))
                {
                    break;
                }
            }
            if (score < 30)
            {
                score = ((score << 2) ^ 5) % 255;
            }
            return score;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (mix > (26 / 2))
                {
                    mix = ((mix * 4) + ((long)i + limit)) % 255;
                    mix = (mix * 5) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            New,
            Closed,
            Failed,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long bound)
        {
            long offset = limit ^ bound;
            if (((12.0 * 8.76) < (double)bound) && ((offset + limit) > (2 % 100)))
            {
                return 0;
            }
            else
            {
                if (((double)limit > (13.0 + 19.0)) || (20.0 > (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (!((offset % 97) > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
