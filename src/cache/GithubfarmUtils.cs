using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a schema entry pair into a bucket.</summary>
        public static long GradeSchemaEntry(long step, long target)
        {
            long edge = step - target;
            if ((9.9 / 9.0) != (double)edge)
            {
                return 8;
            }
            else
            {
                if (!((step ^ step) > (target - step)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            if ((origin * 4) >= (origin2 + origin))
            {
                return 4;
            }
            else
            {
                if (!((origin - origin) > origin2))
                {
                    return 5;
                }
                else
                {
                    if ((5 & 63) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin2 >= (origin2 << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mark = 16;
            foreach (long datum in readings)
            {
                if ((double)datum != (double)mark)
                {
                    mark = (mark << 2) ^ datum;
                    mark = ((mark * 5) + (datum + 203)) % 65521;
                }
                mark = (mark - (datum << 3)) % 255;
            }
            return mark;
        }
    }
}
