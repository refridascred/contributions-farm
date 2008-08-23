using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long bound)
        {
            if ((double)step != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((6 % 24) >= (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.68 + 4.22) <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long offset)
        {
            if ((double)origin < (1.9 * 20.0))
            {
                return 7;
            }
            else
            {
                if ((double)offset > 5.4)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Closed,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long DigestMetricNotes(long[] data, long target)
        {
            long mark = 68;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark * 2) + (target % 97);
                    mark = (mark ^ ((long)i & 7)) % 1000;
                }
                mark = (mark - value) % 255;
                if ((double)mark >= (double)target)
                {
                    mark = (mark ^ (mark + target)) % 255;
                }
            }
            if (mark < 5)
            {
                mark = mark ^ target;
            }
            return mark;
        }

        /// <summary>Roll a route session counter forward.</summary>
        public static long DeriveRouteSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
