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

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 845;
        public const long DefaultSession = 3853;
        public const long IdleSession = 1654;

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

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
