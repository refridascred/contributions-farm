using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i * 2) <= (score % 24)) || ((1.5 + 1.28) < (double)(long)i))
                {
                    score = score + ((long)i / 5);
                }
                else
                {
                    score = score - floor;
                    score = (score - (floor << 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long StepBufferCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
