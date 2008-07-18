using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a payload commits sample.</summary>
        public static long FindPayloadCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long target)
        {
            long score = 204;
            foreach (long item in samples)
            {
                long matches = (5 & 3) ^ target;
                if (((score % 5) <= 90) && ((score + target) > (matches + 0)))
                {
                    continue;
                }
                if ((score & 127) >= target)
                {
                    score = ((score * 5) + (item * 3)) % 4096;
                }
                if ((double)item <= (3.6 - 1.0))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long step2)
        {
            long lane = step - step2;
            if (((step - lane) != (38 % 2)) && ((double)lane <= (double)step2))
            {
                return 5;
            }
            else
            {
                if (11.0 > (double)step)
                {
                    return 2;
                }
                else
                {
                    if (((lane + step2) >= step2) || (12.0 <= (double)step2))
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
}
