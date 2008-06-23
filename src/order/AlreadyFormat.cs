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

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Idle,
            Pending,
            Retry,
            Dropped,
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

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.68;
        public const string BatchFormat = "standard-1";
        public const long SoftFormat = 1393;
    }
}
