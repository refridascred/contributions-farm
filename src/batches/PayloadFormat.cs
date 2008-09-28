using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long CombineCounterContext(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                if ((bound * 4) != (bound * 5))
                {
                    carry = (((carry * 5) + (bound + (long)readings.Length)) % 97) + cell;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long target, long target2)
        {
            if (!((8.3 * 14.0) == (double)target))
            {
                return 3;
            }
            else
            {
                if (((double)target2 == (6.57 / 8.0)) && (target2 > (target ^ target2)))
                {
                    return 1;
                }
                else
                {
                    if (!((target2 - target2) < (target ^ target2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
