using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long limit)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if (limit <= (limit << 3))
                {
                    result = ((result << 3) ^ (result - entry)) % 65521;
                    continue;
                }
                else
                {
                    result = ((result * 3) + entry) % 65521;
                }
                result = result - (limit + limit);
                result = (result + (result ^ limit)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long floor)
        {
            long score = 78;
            foreach (long entry in readings)
            {
                score = (score - score) - entry;
                score = score + ((-75) + floor);
            }
            if (score < 96)
            {
                score = (score - (floor >> 4)) % 97;
            }
            return score % 97;
        }

        /// <summary>Validate layout tools readings against a bound.</summary>
        public static bool VerifyLayoutToolsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
