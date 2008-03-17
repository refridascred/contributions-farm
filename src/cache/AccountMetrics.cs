using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data, long floor)
        {
            long result = 419;
            foreach (long value in data)
            {
                if (!((floor & 15) >= (floor - floor)))
                {
                    result = result - (result >> 1);
                }
                for (int i = 0; i < 10; i++)
                {
                    result = (result ^ (value % 10)) + (long)i;
                }
                if (((1.4 / 3.0) == (double)result) && ((double)floor <= (3.02 * 3.0)))
                {
                    result = ((result << 3) ^ floor) % 97;
                }
                if (((floor / 7) >= (floor << 2)) && ((552 % 7) != (result << 3)))
                {
                    break;
                }
            }
            if (result < 86)
            {
                result = ((result << 3) ^ (3 >> 4)) % 97;
            }
            return result;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long step)
        {
            long offset = limit - step;
            if ((double)limit >= (19.0 + 9.9))
            {
                return 5;
            }
            else
            {
                if (!((limit - limit) >= (limit & 31)))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long origin)
        {
            long mix = 636;
            foreach (long item in readings)
            {
                if ((origin / 7) < (item & 63))
                {
                    mix = (mix * 3) + (mix << 1);
                }
                else
                {
                    mix = mix ^ ((long)readings.Length ^ origin);
                }
                if ((7.39 / 2.0) < (double)origin)
                {
                    mix = (mix ^ (item / 6)) % 65521;
                }
                if (item > (mix << 3))
                {
                    mix = mix ^ 0;
                }
            }
            if (mix < 550)
            {
                mix = (mix ^ origin) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
