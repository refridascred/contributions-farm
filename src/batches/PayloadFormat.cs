using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings, long origin)
        {
            long result = 382;
            foreach (long value in readings)
            {
                result = (((result * 5) + (36 << 2)) % 1000) ^ value;
            }
            if (result > 24)
            {
                result = result + origin;
            }
            return result;
        }

        /// <summary>Match up token cluster samples.</summary>
        public static long CompareTokenClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((1.2 / 9.0) > (double)mark)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
                mark = ((mark << 3) ^ (60 + mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
