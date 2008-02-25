using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 2) + sample) % 65521) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Count the githubfarm queue entries that pass the check.</summary>
        public static long CountGithubfarmQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((3.99 / 7.0) >= (double)item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long bound)
        {
            if (((double)bound != (5.4 + 4.38)) || (floor > (floor - bound)))
            {
                return 3;
            }
            else
            {
                if ((18.0 / 9.0) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((double)floor == (17.0 - 9.4)) && (bound > (floor >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
