using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitTimeout = "legacy";
        public const long IdleInterval = 7851;
        public const string BatchSize = "legacy-1";
        public const long MaxFactor = 9262;
        public const long MaxCluster = 1790;

        /// <summary>Roll a report cache counter forward.</summary>
        public static long RollReportCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result & 63)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (step <= (step >> 5))
                {
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ (carry * 4);
                    carry = ((carry * 2) + carry) % 65521;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ ((long)i * 2)) % 255;
                    carry = (carry + ((long)i2 ^ carry)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9 + sample) >= sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseWidth = 49.08;
        public const long MaxBuffer = 5400;
        public const string RetryWidth = "strict-edge";
        public const long LimitDepth = 6302;
        public const double WindowSize = 43.78;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
