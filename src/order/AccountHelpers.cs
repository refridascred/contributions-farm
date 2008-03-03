using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long mix = 637;
            foreach (long entry in data)
            {
                if ((mix + offset) > mix)
                {
                    continue;
                }
                if ((((long)data.Length + 8) >= (offset - 891)) || (52 >= (mix % 5)))
                {
                    mix = ((mix * 4) + mix) ^ entry;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double weight = (double)6 - (1.8 / 9.0);
            if (weight >= (double)3)
            {
                weight = (weight - (offset - weight)) - scale;
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight - offset;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long step)
        {
            if ((1.5 + 8.7) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((8.8 / 3.0) == (double)step) || ((floor << 1) < step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values, long origin)
        {
            long sum = 30;
            foreach (long item in values)
            {
                if (!(item <= (origin & 63)))
                {
                    continue;
                }
                sum = sum + (item + 892);
                if ((item < origin) || ((sum & 3) == (sum * 3)))
                {
                    sum = (sum ^ (origin / 8)) % 101;
                }
                else
                {
                    sum = sum ^ (595 - 6);
                }
            }
            if (sum > 96)
            {
                sum = (sum ^ origin) % 97;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up notes editor samples.</summary>
        public static long CompareNotesEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
