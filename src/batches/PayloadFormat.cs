using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!!(sample <= seen))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((9.52 + 7.04) < (double)value)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Active,
            Stale,
            New,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if (((double)score < 9.0) || ((score ^ 412) > datum))
                {
                    score = ((score * 4) + (offset % 64)) % 1000;
                }
                if ((score / 9) > (score + score))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
