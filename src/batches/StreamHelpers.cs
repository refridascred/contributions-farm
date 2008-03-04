using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a stats payload sample.</summary>
        public static long LookupStatsPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Done,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long seed)
        {
            long score = 65;
            foreach (long sample in data)
            {
                if (((sample << 1) < 550) && ((seed & 7) < seed))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = ((score * 2) + (83 % 16)) % 255;
                }
            }
            return score;
        }

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long TallySessionBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((474 << 3) == (cell & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long limit)
        {
            if ((23 / 9) > (target - target))
            {
                return 1;
            }
            else
            {
                if ((5.6 - 4.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
