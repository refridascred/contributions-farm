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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((sample + 261) == (sample >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
