using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long RollBatchSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state + offset) % 4096) + (long)i2;
                }
                if ((state ^ state) <= 1)
                {
                    break;
                }
                else
                {
                    state = (state - (offset + (long)i)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "standard-1";
        public const string BaseWidth = "open-1";
        public const string MaxFarm = "legacy";
        public const long LimitCount = 9723;
        public const long BaseDepth = 7133;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
