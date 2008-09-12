using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1185;
        public const string BatchRecord = "local-edge";
        public const string MinRecord = "cached";
        public const double StepRecord = 14.3;
        public const long LimitScore = 8278;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long offset2)
        {
            long span = offset - offset2;
            if (((offset2 & 1) >= 3) || ((double)span >= (10.0 - 9.93)))
            {
                return 8;
            }
            else
            {
                if ((offset2 > (offset - offset2)) || ((offset2 << 2) >= (span << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((span + offset2) > (offset + 562))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((5.01 / 6.0) != (double)score)
                {
                    score = ((score << 2) ^ ((long)i - 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + seen) > ((-7) + seen))
                {
                    seen = ((seen + 3) + datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
