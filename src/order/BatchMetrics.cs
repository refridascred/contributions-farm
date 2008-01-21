using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long state = 71;
            foreach (long item in data)
            {
                state = (state - item) % 255;
                if (!(item <= (step * 5)))
                {
                    state = (state << 3) ^ (item + item);
                }
            }
            if (state > 906)
            {
                state = (state + step) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Check that every schema record entry stays within the limit.</summary>
        public static bool CheckSchemaRecordBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long seed)
        {
            if ((238 * 4) > seed)
            {
                return 4;
            }
            else
            {
                if (61 < (limit ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ ((long)i / 6)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + total) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
