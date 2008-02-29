using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format batch readings.</summary>
        public static long OverlapFormatBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long TallyStreamFarm(long[] values)
        {
            long mark = 71;
            foreach (long reading in values)
            {
                if (((double)mark == (5.0 - 5.4)) && (4.69 <= (double)reading))
                {
                    mark = (mark + (mark / 7)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings)
        {
            long total = 7;
            foreach (long datum in readings)
            {
                if ((3 & 15) <= (datum / 3))
                {
                    total = total ^ (total & 1);
                    total = total ^ datum;
                }
                total = (total ^ (datum + datum)) % 65521;
                if ((total - datum) <= total)
                {
                    total = (total ^ total) % 101;
                }
            }
            if (total < (-28))
            {
                total = (total + (862 + total)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
