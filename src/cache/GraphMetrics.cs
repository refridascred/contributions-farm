using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long DigestProfileFilter(long[] items)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                if ((3.34 * 18.0) > (double)acc)
                {
                    acc = (((acc << 2) ^ (acc >> 4)) % 255) + reading;
                }
            }
            if (acc < (-909))
            {
                acc = acc ^ (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
