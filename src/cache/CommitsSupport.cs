using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long seed)
        {
            if (((double)limit >= (0.45 / 6.0)) || ((double)seed <= (20.0 / 7.0)))
            {
                return 6;
            }
            else
            {
                if (!(seed >= (limit * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) == (limit << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit / 4) >= (seed - 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum << 2);
                if (origin <= (origin + sum))
                {
                    sum = (sum << 2) ^ 3;
                    break;
                }
                else
                {
                    sum = sum + (origin >> 4);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count checks cache pairs that satisfy a relation.</summary>
        public static long PairChecksCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long step)
        {
            long score = 325;
            foreach (long item in levels)
            {
                if ((8.0 + 1.7) == (double)item)
                {
                    score = score + step;
                }
            }
            return score % 4096;
        }
    }
}
