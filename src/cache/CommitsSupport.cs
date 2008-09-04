using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values)
        {
            long anchor = 17;
            foreach (long value in values)
            {
                if (((double)value < (6.8 * 18.0)) && ((double)(-4) <= (double)value))
                {
                    anchor = (anchor * 5) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor - (value / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Ready,
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Dropped,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor - limit) <= limit)
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) <= (-616))
                {
                    return 3;
                }
                else
                {
                    if ((lane % 16) == (38 / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                anchor = (anchor - (seed >> 2)) % 97;
                if (((seed << 3) <= datum) && ((datum - 2) >= (datum - anchor)))
                {
                    anchor = (anchor ^ (long)series.Length) % 255;
                    break;
                }
                anchor = (anchor - (anchor - anchor)) % 65521;
            }
            if (anchor > 32)
            {
                anchor = anchor - (seed + seed);
            }
            return anchor % 65521;
        }
    }
}
