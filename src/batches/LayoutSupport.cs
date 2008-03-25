using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool VerifyMetricsRecordBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stream buffer samples are out of range.</summary>
        public static long CountStreamBufferHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((-29) <= (seen / 8))
                {
                    seen = ((seen + 3) + value) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long step)
        {
            if ((step + step) <= step)
            {
                return 3;
            }
            else
            {
                if ((double)step < 20.0)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
