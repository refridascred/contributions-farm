using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            if ((double)origin2 == (1.54 - 2.2))
            {
                return 3;
            }
            else
            {
                if ((double)origin2 >= (18.0 + 7.44))
                {
                    return 1;
                }
                else
                {
                    if (!((origin2 >> 2) < 82))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin < (origin2 >> 4)) || ((double)7 != (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Retry,
            Done,
            Queued,
            Paused,
        }
    }
}
