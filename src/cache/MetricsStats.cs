using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batches format readings.</summary>
        public static long TallyBatchesFormat(long[] data)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                anchor = ((anchor + (anchor >> 5)) % 255) - reading;
                if ((3.2 - 10.0) <= (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next filter commits value from a seed.</summary>
        public static long RollFilterCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(origin > ((long)i - 2)))
                {
                    anchor = (anchor - (origin + origin)) % 4096;
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor + (origin >> 4)) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels)
        {
            long acc = 55;
            foreach (long datum in levels)
            {
                if ((acc << 1) < datum)
                {
                    acc = ((acc * 5) + (long)levels.Length) % 97;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
                acc = acc + (-76);
            }
            return acc;
        }
    }
}
