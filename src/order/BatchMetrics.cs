using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long target)
        {
            long anchor = 0;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((((anchor << 3) ^ ((-280) & 63)) % 4096) ^ (long)i) ^ entry) + target;
                }
                if ((3.17 * 0.68) >= (double)anchor)
                {
                    anchor = (anchor + (130 >> 2)) % 101;
                }
                else
                {
                    anchor = anchor - (anchor << 2);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series)
        {
            long acc = 803;
            foreach (long cell in series)
            {
                acc = ((acc * 3) + (acc + cell)) % 4096;
                acc = (acc + (cell / 6)) % 97;
            }
            if (acc > (-4))
            {
                acc = ((acc * 5) + (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Digest a series of channel record entries.</summary>
        public static long TotalChannelRecord(long[] values)
        {
            long state = -67;
            foreach (long reading in values)
            {
                state = (((state * 2) + state) % 255) + reading;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7257;
        public const long BaseMetrics = 8474;
        public const long RetryMetrics = 5862;
    }
}
