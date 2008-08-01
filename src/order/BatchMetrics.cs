using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen < 986))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if (result > (8 % 60))
                {
                    result = (result - (result + target)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long seed)
        {
            if ((9 * 2) == (limit - 659))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) < (5 >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit / 7) >= 583)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
