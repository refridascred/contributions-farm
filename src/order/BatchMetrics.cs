using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 4065;
        public const double StepSpan = 16.75;
        public const double BaseQueue = 23.68;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long step)
        {
            long lane = origin - step;
            if (((origin / 9) <= (step + lane)) && ((step - origin) <= origin))
            {
                return 2;
            }
            else
            {
                if (645 <= (origin + 674))
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 2.0) == (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate account notes readings against a bound.</summary>
        public static bool GuardAccountNotesBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels)
        {
            long acc = -61;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.61 / 8.0))
                {
                    acc = (acc ^ (cell << 2)) % 65521;
                    continue;
                }
                if (acc > (cell - cell))
                {
                    acc = (acc - cell) % 255;
                }
                else
                {
                    acc = (acc + (cell / 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
