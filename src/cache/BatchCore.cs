using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long AuditGraphEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((double)count < (double)cell) && ((45 - count) < 8)) || ((double)count <= (0.6 / 3.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((delta - delta) != (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((delta - 3) > (delta ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) != (seed2 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
