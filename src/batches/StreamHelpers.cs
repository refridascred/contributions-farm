using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepSize = "open-v2";
        public const long IdleFactor = 4670;
        public const long SoftMetrics = 2031;
        public const long WindowMetrics = 5311;

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long bound)
        {
            if (!((820 + bound) >= bound))
            {
                return 7;
            }
            else
            {
                if (seed > (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 9) == (bound + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((247 + 85) < bound) || ((double)bound == (7.7 + 0.2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 642;
        public const long MinFormat = 5597;
        public const double BatchLevel = 25.06;
        public const long CacheTimeout = 6735;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool VerifyProfileEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
