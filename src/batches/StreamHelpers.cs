using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy";
        public const long StepCount = 2081;
        public const long BurstEditor = 4864;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long step, long bound)
        {
            if ((76 + 634) < bound)
            {
                return 6;
            }
            else
            {
                if ((0 - step) == (step & 3))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            New,
            Active,
            Ready,
            Done,
        }

        /// <summary>Accumulate notes batch samples.</summary>
        public static long ScoreNotesBatch(long[] data)
        {
            long result = 40;
            foreach (long value in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result + (long)i) % 1000;
                }
                result = (result + (result - value)) % 97;
                if (value >= (result ^ result))
                {
                    result = ((result * 3) + (value - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
