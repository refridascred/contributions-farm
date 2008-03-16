using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long limit)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((state + state) <= (31 + (-9)))
                {
                    state = ((state << 3) ^ (limit << 1)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = state - (long)i;
                }
                state = ((state << 3) ^ (entry % 16)) % 4096;
            }
            if (state > 73)
            {
                state = (state << 2) ^ (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Count commits tools pairs that satisfy a relation.</summary>
        public static long MatchCommitsToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftSize = "cached-1";
        public const long MaxDepth = 3028;
        public const long CacheFarm = 6377;

        /// <summary>Compare every pair of batch context readings.</summary>
        public static long OverlapBatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context channel sample.</summary>
        public static long FindContextChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
