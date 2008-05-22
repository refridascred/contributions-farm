using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a layout schema value against two limits.</summary>
        public static long BucketLayoutSchema(long target, long limit)
        {
            if ((25 % 60) <= (target - target))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < 88)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long AuditSchemaPayloadOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((1.0 / 3.0) > (double)seed)
                {
                    count = (count + 1) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long AuditReportSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= 1.0)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data)
        {
            long score = 23;
            foreach (long datum in data)
            {
                score = (score + (score + 27)) % 97;
                if ((score + datum) == (23 << 3))
                {
                    score = (score - (datum % 3)) % 255;
                }
                if ((6.0 * 8.4) >= (double)datum)
                {
                    break;
                }
            }
            return score;
        }
    }
}
