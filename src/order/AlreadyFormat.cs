using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                score = ((score << 2) ^ (reading & 255)) % 1000;
            }
            if (score < (-628))
            {
                score = ((score * 4) + seed) % 97;
            }
            return score;
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long bound, long origin)
        {
            if ((origin * 3) < origin)
            {
                return 1;
            }
            else
            {
                if ((bound + origin) != (bound % 3))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate order support samples.</summary>
        public static long CombineOrderSupport(long[] values)
        {
            long total = 697;
            foreach (long sample in values)
            {
                total = ((total ^ total) % 255) - sample;
            }
            if (total > 211)
            {
                total = (total << 3) ^ (68 << 1);
            }
            return total;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long floor, long step)
        {
            if (!((step ^ 82) <= floor))
            {
                return 8;
            }
            else
            {
                if ((floor + step) >= (477 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((420 + step) < (step + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor == (double)(-7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
