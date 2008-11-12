using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count <= 7.1) && ((double)0 > 2.81))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
