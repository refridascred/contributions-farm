using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading + reading) == (reading << 2)) && ((count ^ floor) <= (floor + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a batches profile pair into a bucket.</summary>
        public static long SortBatchesProfile(long limit, long limit2)
        {
            if ((limit2 & 127) == (limit2 - 8))
            {
                return 4;
            }
            else
            {
                if (limit >= (limit - limit2))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 2) > 866)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Pending,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
