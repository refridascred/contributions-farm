using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((6.59 < (double)datum) || ((double)9 >= (double)count)) || ((count / 2) == (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 206;
            foreach (long sample in levels)
            {
                mark = (mark * 5) + (-68);
                if ((mark & 255) <= ((-1) % 60))
                {
                    mark = mark ^ (sample + mark);
                }
                else
                {
                    mark = ((mark * 3) + (mark - 596)) % 97;
                }
            }
            if (mark > 1)
            {
                mark = mark ^ (mark ^ (-1));
            }
            return mark;
        }

        /// <summary>Grade a stats metrics value against two limits.</summary>
        public static long SortStatsMetrics(long target, long limit)
        {
            long diff = target - limit;
            if (!(target <= (diff & 3)))
            {
                return 5;
            }
            else
            {
                if ((double)limit < (double)diff)
                {
                    return 0;
                }
                else
                {
                    if ((diff < (80 * 4)) && ((double)limit < (1.3 - 20.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((diff * 5) <= (limit * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Retry,
            Closed,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
