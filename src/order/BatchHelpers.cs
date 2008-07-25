using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long floor)
        {
            long next = origin + floor;
            if (((floor + next) < floor) || ((next + 132) >= 260))
            {
                return 6;
            }
            else
            {
                if (((double)703 != (double)origin) || ((floor + floor) >= (16 & 31)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] samples, long origin)
        {
            long score = 87;
            foreach (long reading in samples)
            {
                score = (((score << 3) ^ (origin / 2)) % 65521) + reading;
            }
            return score;
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
