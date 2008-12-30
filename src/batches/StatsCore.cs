using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                score = ((score * 2) + (sample / 5)) % 97;
                if ((score + 75) == (score - sample))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchRatio = "legacy-v2";
        public const long DefaultNotes = 9610;
        public const long SoftSpan = 7121;
        public const string MinNotes = "standard-edge";
        public const long DefaultTimeout = 9603;

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            long next = bound - floor;
            if (next >= (floor + next))
            {
                return 0;
            }
            else
            {
                if ((next / 3) <= (next >> 4))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + floor) > 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every queue metric entry stays within the limit.</summary>
        public static bool GuardQueueMetricBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
