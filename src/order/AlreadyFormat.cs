using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next context batches value.</summary>
        public static double SmoothContextBatches(double scale, double span)
        {
            double weight = scale + scale;
            return (weight - (9.9 + weight)) + span;
        }

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long ClassifyBufferReport(long limit, long step)
        {
            long edge = limit - step;
            if (17.0 >= (double)step)
            {
                return 1;
            }
            else
            {
                if ((limit + edge) >= edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
