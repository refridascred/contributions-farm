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

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
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

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next command farm value from a seed.</summary>
        public static long StepCommandFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((offset << 3) > (3 ^ offset)) && ((offset - anchor) == (anchor % 8)))
                {
                    break;
                }
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
