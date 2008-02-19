using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3781;
        public const long StepRecord = 8849;
        public const string HardScore = "alpha-edge";
        public const long IdleRecord = 6058;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long bound)
        {
            long bound2 = step ^ bound;
            if ((bound + bound) >= step)
            {
                return 2;
            }
            else
            {
                if ((bound2 >> 3) != (step + 9))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up stream order samples.</summary>
        public static long OverlapStreamOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((mark / 7) >= (long)i)
                {
                    mark = ((mark * 2) + (71 % 12)) % 65521;
                }
                else
                {
                    long delta = seed / 5;
                    mark = (mark * 2) + delta;
                }
                mark = mark ^ (seed ^ mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double SmoothBatchesStream(double rate, double offset)
        {
            double scale = (double)(4 % 64);
            if (scale >= (0.14 * 5.9))
            {
                scale = (scale - (double)10) + rate;
            }
            return scale + (offset * 5.1);
        }
    }
}
