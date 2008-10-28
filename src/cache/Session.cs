using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) > (tally + 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((25 + tally) != (tally - tally)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
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
