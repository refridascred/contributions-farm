using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data)
        {
            long result = 34;
            foreach (long datum in data)
            {
                if (((result / 9) > ((long)data.Length & 255)) || ((double)datum == (0.3 / 7.0)))
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data, long target)
        {
            long total = 406;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (total << 1)) % 1000) + target;
                total = total - total;
                if ((item + item) == ((long)data.Length << 2))
                {
                    total = total ^ total;
                }
            }
            return total;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long seed)
        {
            long span = offset + seed;
            if (((5.12 * 3.0) < (double)span) && ((span & 63) > (seed % 5)))
            {
                return 4;
            }
            else
            {
                if ((-6) < (472 + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset - span) > (offset ^ span)) && ((span << 3) <= 19))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (double)span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel commits input into a small class.</summary>
        public static long BucketChannelCommits(long limit, long offset)
        {
            long edge = limit + offset;
            if (edge <= (edge << 1))
            {
                return 3;
            }
            else
            {
                if (((double)limit > (double)edge) && ((8.1 + 5.04) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (offset ^ edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit > (2.5 - 19.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            New,
            Draft,
            Synced,
            Closed,
        }
    }
}
