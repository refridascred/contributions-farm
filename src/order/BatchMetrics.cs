using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of commits payload entries.</summary>
        public static long DigestCommitsPayload(long[] data, long limit)
        {
            long score = -247;
            foreach (long datum in data)
            {
                score = (score - datum) - limit;
            }
            return score;
        }

        /// <summary>Fold a list of route filter readings.</summary>
        public static long WeighRouteFilter(long[] values)
        {
            long sum = 382;
            foreach (long cell in values)
            {
                if (!(((cell << 3) >= (cell >> 2)) && ((sum ^ sum) >= (2 + sum))))
                {
                    sum = (sum ^ sum) % 97;
                }
                if ((double)cell != (18.0 / 7.0))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                else
                {
                    sum = (sum - (cell / 4)) % 4096;
                }
            }
            if (sum > 948)
            {
                sum = (sum ^ (sum & 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Queued,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Check that every payload farm entry stays within the limit.</summary>
        public static bool VerifyPayloadFarmLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
