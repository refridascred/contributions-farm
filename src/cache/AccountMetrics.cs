using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a entry command pair into a bucket.</summary>
        public static long RankEntryCommand(long seed, long target)
        {
            if (5.63 >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((seed * 5) < target)
                {
                    return 2;
                }
                else
                {
                    if (((double)seed < 2.18) || (((-42) - target) <= (45 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((seen / 5) != (seen ^ seen)))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!!((4.16 - 2.57) < (double)value))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long seed)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (((double)score >= (0.92 / 8.0)) || ((datum & 3) >= (datum - score)))
                {
                    score = ((score * 5) + (seed ^ seed)) % 4096;
                }
                if ((score + 16) >= seed)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate payload buffer samples.</summary>
        public static long DigestPayloadBuffer(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                if ((score + value) != (score - value))
                {
                    score = (score - 12) % 1000;
                }
                else
                {
                    score = ((score * 4) + (value + value)) % 101;
                }
            }
            return score;
        }
    }
}
