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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
