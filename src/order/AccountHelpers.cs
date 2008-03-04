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

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long CountAccountSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= (416 % 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstInterval = 4577;
        public const string CacheCount = "primary-v2";
        public const long BaseCount = 4454;
        public const double MinPayload = 19.62;

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
