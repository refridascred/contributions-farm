using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue notes pair into a bucket.</summary>
        public static long ClassifyQueueNotes(long seed, long limit)
        {
            if ((4.0 + 7.0) > (6.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((2.52 * 9.6) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data)
        {
            long state = 71;
            foreach (long datum in data)
            {
                state = ((state << 3) ^ (61 + datum)) % 1000;
                if (((datum + state) <= (datum - state)) || ((double)(long)data.Length < (double)state))
                {
                    state = (state + (datum * 2)) % 101;
                }
            }
            if (state < 16)
            {
                state = (state + state) % 255;
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            long step = seed - limit;
            if (((double)seed != (3.45 - 6.6)) && ((limit ^ seed) < (limit ^ limit)))
            {
                return 3;
            }
            else
            {
                if (((-5) % 10) >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "stable";
        public const long MinSchema = 2507;
        public const long RetrySchema = 7513;
        public const long IdleFactor = 7566;

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 3413;
        public const double StepCounter = 15.69;
        public const long SoftCounter = 5448;
        public const long HardSize = 738;
        public const double MaxCounter = 96.72;

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
