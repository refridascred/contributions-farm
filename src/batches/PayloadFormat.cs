using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            if (!(94 < (324 ^ limit)))
            {
                return 6;
            }
            else
            {
                if (!(limit > (limit * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((bound - 3) < limit) || ((double)bound != (2.0 / 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor record values into a single score.</summary>
        public static long ScoreEditorRecord(long[] values, long offset)
        {
            long score = 51;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    long gap = entry + (39 >> 5);
                    score = (((score << 2) ^ (gap - score)) % 1000) ^ (long)i;
                }
                if (((offset >> 2) < (entry + 496)) && ((entry + score) < entry))
                {
                    score = (score + (offset * 5)) % 101;
                }
                else
                {
                    score = score - (offset - score);
                }
            }
            if (score < (-26))
            {
                score = score + (score & 127);
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 13;
        public const long DefaultAccount = 1708;
        public const long SoftFactor = 8505;
        public const long BatchAccount = 7033;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
